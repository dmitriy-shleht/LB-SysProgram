using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Monitor
{
    class Program
    {
        private static int value = 0;
        private static object obj = new object();

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
                System.Threading.Monitor.Enter(obj);
                value++;
                System.Threading.Monitor.Exit(obj);
            }
        }
        private static void Dec()
        {
            for (int i = 0; i < 1000000; i++)
            {
                System.Threading.Monitor.Enter(obj);
                value--;
                System.Threading.Monitor.Exit(obj);
            }
        }
    }
}
