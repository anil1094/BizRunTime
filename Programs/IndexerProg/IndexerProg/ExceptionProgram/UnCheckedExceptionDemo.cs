﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class UnCheckedExceptionDemo
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
                Console.ReadLine();
            }

        }
    }
}
