using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Read
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Mutex.OpenExisting("StartRW");

            for (int i = 0; i < 1000000; i++)
            {
                if (File.Exists("1.txt"))
                {
                    m.WaitOne();
                    using (var sr = new StreamReader("1.txt"))
                    {
                        while (!sr.EndOfStream)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine(sr.ReadLine());
                        }
                    }
                    m.ReleaseMutex();
                }
            }
        }
    }
}
