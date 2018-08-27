using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.IndexerDemo
{
    class Employee
    {
         int Eno;
         double salary;
         String Ename, job, Dname, Location;
       public Employee(int Eno,double salary,string Ename,string job,string Dname,string Location)
        {
            this.Eno = Eno;
            this.salary = salary;
            this.Ename = Ename;
            this.job = job;
            this.Dname = Dname;
            this.Location = Location;
        }
        public object this[int index]

        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return salary;
                else if (index == 2)
                    return Ename;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
            }
            set
            {
                if(index==0)
                Eno = (int)value;
                if (index == 1)
                    salary= (double)value;
                if (index == 2)
                    Ename = (string)value;
                if (index == 3)
                    job = (string)value;
                if (index == 4)
                    Dname = (string)value;
                if (index == 5)
                    Location = (string)value;
            }
        }
    }
}
