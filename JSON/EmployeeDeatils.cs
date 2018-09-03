using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

namespace IndexerProg.JSON
{
    class EmployeeDeatils
    {
        static void Main(string[] args)
        {
            var obj = new List<ExpandoObject>();
            dynamic a = new ExpandoObject();
            a.name = "Amit";
            a.adress = "bangalore";
            a.salary = 1000;
            a.age = 22;

            dynamic b = new ExpandoObject();
            b.name = "ashish";
            b.adress = "kanpur";
            b.salary = 7000;
            b.age = 20;

            dynamic c = new ExpandoObject();
            c.name = "ankit";
            c.adress = "noida";
            c.salary = 100000;
            c.age = 25;


            dynamic d = new ExpandoObject();
            d.name = "hanu";
            d.adress = "lucknow";
            d.salary = 15000;
            d.age = 27;

            obj.Add(a);
            obj.Add(b);
            obj.Add(c);
            obj.Add(d);


            var result = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            Console.WriteLine(result);

            var resultObject = JsonConvert.DeserializeObject<List<ExpandoObject>>(result, new ExpandoObjectConverter());

            Console.WriteLine();
            Console.WriteLine();

            foreach(dynamic r in resultObject)
            {
                Console.WriteLine("Name is : " + r.name + "\n ");
                Console.WriteLine("Adress is : " + r.adress + "\n");
                Console.WriteLine("Salary is : " + r.salary + "\n");
                Console.WriteLine("Age is : " + r.age + "\n");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
