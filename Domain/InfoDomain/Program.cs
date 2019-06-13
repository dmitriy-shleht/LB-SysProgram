using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            Info(AppDomain.CurrentDomain);

            var newDomain = AppDomain.CreateDomain("Dmitriy-Schleht");

            Info(newDomain);
            Console.ReadKey();
        }

        private static void Info(AppDomain appDomain)
        {
            Console.WriteLine($"Имя:{appDomain.FriendlyName}, ИД:{appDomain.Id}, Default:{appDomain.IsDefaultAppDomain()}, Путь:{appDomain.BaseDirectory}");

            Console.WriteLine("--------Сборки---------");

            foreach (var item in appDomain.GetAssemblies())
            {
                Console.WriteLine($"Имя:{item.GetName()}, Версия:{item.GetName().Version}");
            }

            Console.WriteLine("\n\n");
        }
    }
}
