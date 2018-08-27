using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.IndexerDemo
{
    class InterfaceIndexerMainCLass
    {
        static void Main(string[] args)
        {
            IndexerClass test = new IndexerClass();
           System.Random rand= new System.Random();
            for(int i=0;i<=10;i++)
            {
                test[i] = rand.Next();
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("indexer {0}={1} ", i, test[i]);
            }
            Console.ReadLine();
        }

    }
}
