using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Temp\Text.txt";
            string  text="";
            int  nline =0;
            int  nword =0;
            int  nchar =0;

            using (StreamReader sr = new StreamReader(path))
            {

                do
                {
                    text+=" "+sr.ReadLine();
                    nline ++;
                }
                while(!sr.EndOfStream );
                
                text = text.Trim();
                string [] arrayText = text.Split();
                foreach (string a in arrayText) 
                {
                    nword++;
                }


                text = text.Replace(" ", "");

                nchar = text.Length;

                Console.WriteLine("Чисто строк в файле-{0}\nЧисло слов в файле-{1}\nЧисло символов в файле-{2}", nline, nword, nchar);
                Console.ReadKey();

            }
        }
    }
}
