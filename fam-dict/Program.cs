using System;
using System.Collections.Generic;


namespace fam_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            
            myFamily.Add("dad", new Dictionary<string, string>(){ 
                {"name", "Phil"},
                {"age", "62"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){ 
                {"name", "Sheri"},
                {"age", "52"}
            });

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Amy"},
                {"age", "32"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Adam"},
                {"age", "21"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                Console.WriteLine(member.Value["name"] + " is my " + member.Key + " and is " + member.Value["age"] + " years old.");
            }
        }
    }
}
