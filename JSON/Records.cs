using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.JSON
{
    class Records
    {
        static void Main(string[] args)
        {
            dynamic obj = new ExpandoObject();
            obj.name = "anil";
            obj.skill = "JSON";
            obj.id = 234;


            obj.records = new ExpandoObject();
            obj.records.department = "MCA";
            obj.records.rollno = 123;
            obj.records.subject = "Java";

            var result = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            Console.WriteLine(result);

            var r =JsonConvert.DeserializeObject<ExpandoObject>(result, new ExpandoObjectConverter());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Name is : " + r.name + "\n");
            Console.WriteLine("skilss is : " + r.skill + "\n");
            Console.WriteLine("id is: " + r.id + "\n");

            Console.WriteLine();
            Console.WriteLine("Department is : " + r.records.department + "\n");
            Console.WriteLine("Rollno is : " + r.records.rollno + "\n");
            Console.WriteLine("Subjectis : " + r.records.subject + "\n");
            Console.ReadLine();
        }
    }
}
