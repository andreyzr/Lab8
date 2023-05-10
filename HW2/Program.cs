using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Temp\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0, 10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                        k+= Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
