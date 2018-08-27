using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProg.ExceptionProgram
{
    class FileExceptionDemo
    {
        static void Main()
        {
            try
            {
                StreamReader sr = File.OpenText("D:\\data.txt");
                Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            Console.ReadLine();
        }
    }
}
