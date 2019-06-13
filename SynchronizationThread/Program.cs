using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SynchronizationThread
{
    class Program
    {
        private static int value = 0;
        private static int lockValue = 0;

        static void Main(string[] args)
        {
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
                //Interlocked.Increment(ref value);
                MyLock(() => { value++; });
            }
        }
        private static void Dec()
        {
            for (int i = 0; i < 1000000; i++)
            {
                //Interlocked.Decrement(ref value);
                MyLock(() => { value--; });
            }
        }

        private static void MyLock(Action action)
        {
            while (1 == Interlocked.Exchange(ref lockValue, 1))
            {
                Thread.Sleep(10);
            }
            action();
            Interlocked.Exchange(ref lockValue, 0);
        }
    }
}