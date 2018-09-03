using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProg.JSON
{
    class StudMain
    {
        static void Main(string[] args)
        {
            //Serialize data into JSON
            Student st = new Student()
            {
                id = 1,
                Name = "anil",
                Degree = "MCA",
            Hobbies=new List<string>()
            {
                "Reading",
                "Playing"

            }
            };

            //convert student object into jSON data

            string strResultJson = JsonConvert.SerializeObject(st);
            Console.WriteLine(strResultJson);

            //store json data into file

            File.WriteAllText("D:\\student.json", strResultJson);
            Console.WriteLine("stored");


            // deserilization data again into student format
            strResultJson = string.Empty;
            strResultJson = File.ReadAllText("D:\\student.json");
           Student resultStudent=JsonConvert.DeserializeObject<Student>(strResultJson);
            Console.WriteLine(resultStudent.ToString());
            Console.ReadLine();
        }
    }
}
