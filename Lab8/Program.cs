using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives=DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Название: {0}", drive.Name);
                if (drive.IsReady)
                {
                    Console.WriteLine("Объем диска: {0}", drive.TotalSize);
                    Console.WriteLine("Свободно: {0}",drive.AvailableFreeSpace);
                }
            }
            Console.ReadKey();
        }
    }
}
