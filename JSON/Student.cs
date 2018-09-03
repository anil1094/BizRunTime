using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.JSON
{
    class Student
    {
        public int id { get; set; }
        public String Name{ get; set; }
       public string Degree { get; set; }
       public List<string> Hobbies { get; set; }

        public override string ToString()
        {
            return string.Format("student information :\n\tId: {0} ,\n\tName:{1},Degree:{2}\n\t, " + "Hobbies:{3}", id, Name, Degree, string.Join(",", Hobbies.ToArray()));
        }

    }
}
