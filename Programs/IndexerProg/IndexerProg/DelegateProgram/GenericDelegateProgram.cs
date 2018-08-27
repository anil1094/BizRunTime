using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.DelegateProgram
{
    //public delegate double delegate1(int a, float b, double c);
    //public delegate void delegate2(int x, float y, double z);
    //public delegate bool checkLength(String str);
    class GenericDelegateProgram
    {
        public static double AddNum1(int a,float b,double c)
        {
            return a + b + c;
        }
        public static void AddNum2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool checkLength(String str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int,float,double,double> obj1= AddNum1;
            double result=obj1.Invoke(10, 3.5f, 6.7);
            Console.WriteLine(result);
            Action<int,float,double> obj2 = AddNum2;
            obj2.Invoke(15, 4.5f, 5.8);
            Predicate<string> obj3 = checkLength;
           bool status= obj3.Invoke("anilsingh");
             Console.WriteLine(status);
            Console.ReadLine();

        }
    }
}
