using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    interface interface3
    {
        void show();
    }
    interface interface4
    {
        void show();
    }

    class MultipleInheritanceTest1 : interface3, interface4
    {
              void interface3.show()
            {
                Console.WriteLine("show interface3");
            }
             void interface4.show()
            {
                Console.WriteLine("show interface4");
            }
        static void Main(string[] args)
        {
            MultipleInheritanceTest1 obj1 = new MultipleInheritanceTest1();
            interface3 i1= obj1;
            interface4 i2=obj1;
            i1.show();
            i2.show();
            //interface3 i1 = (interface3)obj1;
            // interface4 i2 = (interface4)obj1;
            Console.ReadLine();
               
        }

        }
        
    }

