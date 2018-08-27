using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.LProgram
{
    class ConsDemo
    {
        int age;
        String name;
        public ConsDemo(int ag, string nam)
        {

            age = ag;
           name = nam;
        }
        public void display()

        {
            Console.WriteLine("Age is " + age);
            Console.WriteLine("name is " + name);
        }
        static void Main(string[] args)
        {
            ConsDemo c = new ConsDemo(10, "Anil");
            c.display();
            Console.ReadLine();

        }


    }
}
