using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.DelegateProgram
{
    public delegate string GreetingDelegate(String name);
    class AnonymousMethodsDemo
    {
       
        static void Main(string[] args)
        {
            GreetingDelegate obj = delegate (String name)
            {
                return "hello " + name + " Very Good Morning";
            };
            string str = obj.Invoke("anil");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}


