using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TEsting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyTest.txt";
            Lines(path);
        }

        static void Lines(string path)
        {
            // pu joyda file ni ichiga malumot yozib olyabmiz atak malumoti bor file ni pathi berilsa bu shart emas
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int i = 1;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(i + "     " + s);
                    i++;
                }
            }
        }
    }
}


