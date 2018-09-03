using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IndexerProg.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("https://jsonplaceholder.typicode.com/posts/1");
            PostJson post = JsonConvert.DeserializeObject<PostJson>(text);
            Console.WriteLine("userId is := " + post.userId);
            Console.WriteLine("id is := " + post.id);
            Console.WriteLine("title is := " + post.title);
            Console.WriteLine("body is := " + post.body);
            Console.ReadLine();

        }
    }
}
