using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Concurrency
{
    class Program
    {
        private static int valueA = 0;
        private static int valueB = 0;

        private static object sectionA = new object();
        private static object sectionB = new object();
        
        static void Main(string[] args)
        {
            //Thread inc = new Thread(new ThreadStart(Inc));
            //Thread dec = new Thread(new ThreadStart(Dec));

            //Thread inc = new Thread(new ThreadStart(Inc1));
            //Thread dec = new Thread(new ThreadStart(Dec1));

            Thread inc = new Thread(new ThreadStart(Inc2));
            Thread dec = new Thread(new ThreadStart(Dec2));

            inc.Start();
            dec.Start();
            inc.Join();
            dec.Join();

            Console.WriteLine(valueA);
            Console.WriteLine(valueB);
            Console.ReadKey();
        }

        private static void Inc()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (sectionA)
                {
                    valueA++;
                    lock (sectionB)
                    {
                        valueB--;
                    }
                }
            }
        }
        private static void Dec()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (sectionB)
                {
                    valueB++;
                    lock (sectionA)
                    {
                        valueA--;
                    }
                }
            }
        }


        private static void Inc1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (sectionA)
                {
                    valueA++;
                }
                lock (sectionB)
                {
                    valueB--;
                }
            }
        }
        private static void Dec1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (sectionB)
                {
                    valueB++;
                }
                lock (sectionA)
                {
                    valueA--;
                }
            }
        }

        private static void Inc2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (sectionA)
                {
                    valueA++;
                    lock (sectionB)
                    {
                        valueB--;
                    }
                }
            }
        }

        private static void Dec2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (sectionA)
                {
                    valueB++;
                    lock (sectionB)
                    {
                        valueA--;
                    }
                }
            }
        }
    }
}
