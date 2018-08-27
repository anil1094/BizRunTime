using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    interface Interface1
    {
         int mul(int a, int b);
         int div(int a, int b);
    }
    class TestInterface:Interface1
    {
        public int mul(int a,int b)
        {
            return a * b;
        }
        public int div(int a,int b)
        {
            return a / b;
        }
    }
    
    }

