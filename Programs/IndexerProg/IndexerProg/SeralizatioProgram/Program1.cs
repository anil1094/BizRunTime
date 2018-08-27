using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace IndexerProg.SeralizatioProgram
{
    class Program1
    {
        private const string filename = "D:\\test.txt";
        public static void Main(string[] args)
        {
            Tutorial objWrite = new Tutorial();
            objWrite.title = "Serializable overview";
            objWrite.pagecount = 10;
            objWrite.author = "Pramesh";

            // serializing
            FileStream stream = File.Create(filename);
            BinaryFormatter format = new BinaryFormatter();
              format.Serialize(stream, objWrite);

               stream.Close();

                //deserlize

                stream = File.OpenRead(filename);

                Tutorial objRead = (Tutorial)format.Deserialize(stream);
                stream.Close();
                Console.ReadLine();


        }

    }
        [Serializable]
        public class Tutorial
         { 
            public string title;
            public int pagecount;
            public string author;

        }
    
}
