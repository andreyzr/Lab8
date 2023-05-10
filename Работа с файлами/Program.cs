using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Работа_с_файлами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/Log.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Старт прогаммы");
                sw.WriteLine("Ошибка");
                sw.Close();
            }
            using(StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();

        }
    }
}
