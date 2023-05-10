using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Temp";
            string[] Directorys = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);
            foreach (string Directory in Directorys)
            {
                Console.WriteLine(Directory);
            }
            Console.ReadKey();

        }
    }
}
