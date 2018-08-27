using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.IndexerDemo
{
    class Person1
    {
        public String[] str = { "anil", "amit", "ashish", "hanu", "ankit" };
        public string this[int indexer]
        {
            set
            {
                str[indexer] = value;
            }
            get
            {
                return str[indexer];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person1 p1 = new Person1();
           Console.WriteLine("first name {0}, Second name {1} ", p1[0], p1[1]);
            Console.ReadLine();
        }
    }
}

