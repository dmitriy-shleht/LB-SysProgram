using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Mutex
{
    class Program
    {
        private static int value = 0;
        private static System.Threading.Mutex _mutex = new System.Threading.Mutex();

        static void Main(string[] args)
        {
            var mutex = new System.Threading.Mutex(false, "Mutex", out bool result);

            if (!result)
            {
                return;
            }

            Thread inc = new Thread(new ThreadStart(Inc));
            Thread dec = new Thread(new ThreadStart(Dec));

            inc.Start();
            dec.Start();
            inc.Join();
            dec.Join();

            Console.WriteLine(value);
            Console.ReadKey();
        }

        private static void Inc()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _mutex.WaitOne();
                value++;
                _mutex.ReleaseMutex();
            }
        }
        private static void Dec()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _mutex.WaitOne();
                value--;
                _mutex.ReleaseMutex();
            }
        }
    }
}
