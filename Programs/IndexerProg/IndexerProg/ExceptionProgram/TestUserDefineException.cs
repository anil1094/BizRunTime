using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
    }
    class TestUserDefineException
    {
            public static void validate(int age)
            {
                if(age<18)
                {
                    throw new InvalidAgeException("Sorry age must be grater then 18");
                }
                else
            {
                Console.WriteLine("you are perfect");
            }
            }
            static void Main(string[] args)
            {
                try
                {
                    validate(12);
                }
                 catch (InvalidAgeException e)
               {
                    Console.WriteLine(e.Message);
               }
            Console.WriteLine("end of the code");
                Console.ReadLine();
            }

                 

    }
        
}
