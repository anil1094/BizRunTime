using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProg.ExceptionProgram
{
    class InvalidCastExceptionDemo
    {
        static void Main(string[] args)
        {
            StringBuilder obj1 = new StringBuilder();
            object obj2=obj1;
            StreamReader obj3 = (StreamReader)obj2;
        }
    }
}
