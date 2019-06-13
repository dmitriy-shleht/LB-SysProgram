using System;
using System.IO;
using System.Threading;

namespace Write
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Mutex.OpenExisting("StartRW");
            var rnd = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                m.WaitOne();
                using (var sw = new StreamWriter("1.txt", true))
                {
                    var val = rnd.Next(1000000);
                    sw.Write(val);
                    Thread.Sleep(400);
                    Console.WriteLine($"Записано:{val}");
                }
                m.ReleaseMutex();
            }
        }
    }
}
