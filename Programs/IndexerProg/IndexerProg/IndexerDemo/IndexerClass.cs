using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.IndexerDemo
{
    interface IsomeInterface
    {
        int this[int index]
        {
            get;
            set;
        }
    }
    class IndexerClass : IsomeInterface
    {
        int[] arr = new int[100];
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}
