using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Работа_с_каталогами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2";
            /*if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }*/
            DirectoryInfo directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
        }
    }
}
