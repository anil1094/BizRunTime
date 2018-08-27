using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndexerProg.DelegateProgram
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(String str);
    class Program2
    {
        public void AddNum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public string SayHello(String name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program2 p = new Program2();
            AddDelegate ad = new AddDelegate(p.AddNum);
            ad(10, 30);
            SayDelegate sd = new SayDelegate(p.SayHello);
            String str = sd("anil");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
