using System;
using System.IO;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = DriveInfo.GetDrives();

            foreach (var item in info)
            {
                Console.WriteLine($"Имя диска: {item.Name}");
                Console.WriteLine($"Тип диска: {item.DriveType}");

                if (item.IsReady)
                {
                    Console.WriteLine($"Метка тома: {item.VolumeLabel}");
                    Console.WriteLine($"ФС: {item.DriveFormat}");
                    Console.WriteLine($"Доступно места: {item.AvailableFreeSpace / Math.Pow(1024f, 3):0.##}Gb");
                    Console.WriteLine($"Всего места: {item.TotalFreeSpace / Math.Pow(1024f, 3):0.##}Gb");
                    Console.WriteLine($"Общий размер: {item.TotalSize / Math.Pow(1024f, 3):0.##}Gb");
                }

                Console.WriteLine($"--------------------------------");
            }

            Console.ReadKey();
        }
    }
}
