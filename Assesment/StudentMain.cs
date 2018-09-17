using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleAssesment.Answer2
{
    class StudentMain
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the adress");
            string Adress = Console.ReadLine();
            Console.WriteLine("enter the phoneNumber");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the email id");
            string email = Console.ReadLine();


            List<Student> llist1 = new List<Student>();
            llist1.Add(new Student()
            {
                name = name,
                Adress = Adress,
                number = number,
                email = email


            });


            string result = JsonConvert.SerializeObject(llist1);
            Console.WriteLine(result);
            File.WriteAllText("D:\\stm.json", result);
            Console.WriteLine("stored");
        }
    }
}
