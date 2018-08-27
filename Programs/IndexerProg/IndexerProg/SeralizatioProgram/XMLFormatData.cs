using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace IndexerProg.SeralizatioProgram
{
    public class XMLFormatData
    {
        static void Main(string[] args)
        {
             WriteXML();
           // ReadXml();
        }
        public static void WriteXML()
        {
            Tutorial1 objWrite = new Tutorial1();
            objWrite.pagecount = 10;
            objWrite.author = "Ramesh";

            XmlSerializer writer = new XmlSerializer(typeof(Tutorial1));
            string pathtosave = "D:\\tempxml.xml";
            FileStream file = File.Create(pathtosave);
            writer.Serialize(file, objWrite);
            file.Close();
            Console.ReadLine();
        }
        //public static void ReadXml()
        //{
        //    XmlSerializer reader = new XmlSerializer(typeof(Tutorial1));
        //    StreamReader file =new StreamReader("D:\\tempxml.xml");
        //    Tutorial1 objRead=(Tutorial1)reader.Deserialize(file);
        //    file.Close();
        //    Console.ReadLine();
                    
        //}
        public class Tutorial1
        {
            public string title;
            public int pagecount;
            public string author;
        }
    }
}
