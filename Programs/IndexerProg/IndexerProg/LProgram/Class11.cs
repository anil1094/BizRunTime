using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace IndexerProg.LProgram
{
   public class Class11
    {

        private const string Pattern = @"\/(?<argname>\w+):(?<argvalue>.+)";
        private readonly Regex _regex = new Regex(Pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private readonly Dictionary<String, String> _args =
            new Dictionary<String, String>();

        public  Class11()
        {
            BuildArgDictionary();
        }

        public string this[string key]
        {
            get
            {
                return _args.ContainsKey(key) ? _args[key] : null;
            }
        }

        public bool ContainsKey(string key)
        {
            return _args.ContainsKey(key);
        }
        public void BuildArgDictionary()
        {
            var args = Environment.GetCommandLineArgs();
            foreach (var match in args.Select(arg =>
                        _regex.Match(arg)).Where(m => m.Success))
            {
                try
                {
                    _args.Add(
                         match.Groups["argname"].Value,
                         match.Groups["argvalue"].Value);
                }
                // Ignore any duplicate args
                catch (Exception) { }

            }
            Console.ReadLine();
        }
    }
    class class123
    {
        static void Main(string[] args)
        {
            Class11 obj = new Class11();
                obj.BuildArgDictionary();
            obj.ContainsKey("anil");
            Console.ReadLine();
        }
    }
}
