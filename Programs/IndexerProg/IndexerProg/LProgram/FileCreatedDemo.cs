using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProg.LProgram
{
    class FileCreatedDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"D:\sw\anil.txt");
            sw.Write(str);
            sw.Close();
            Console.WriteLine();

        }
    }
}
