using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    class MainClassExplicitInterface
    {
        static void Main(string[] args)
        {
            BOX x = new BOX(12.4f,5.7f);
            IDimesions i = (IDimesions)x;
            Console.WriteLine(i.getLength());
            Console.WriteLine(i.getWidth());
            Console.ReadLine();
        }

    }
}
