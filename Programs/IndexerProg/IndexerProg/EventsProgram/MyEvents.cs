using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.EventsProgram
{
    public delegate void myEventHandler(string newValue);
    class EventExample
    {
        private string theValue;
        public event myEventHandler valuechanged;
        public  string val
        {
            set
            {
                this.theValue = value;
                this.valuechanged(theValue);

            }
        }
    }
    class MyEvents
    {
        static void Main(string[] args)
        {
            EventExample myEvt = new EventExample();
            myEvt.valuechanged += new myEventHandler(myEvt_valueChanged);
            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit"))

                {
                    myEvt.val = str;
                }
            }
            while (!str.Equals("exit"));
        }
        static void myEvt_valueChanged(string newValue)
        {
            Console.WriteLine("the value change to {0} ", newValue);
        }

            
        }
    }

