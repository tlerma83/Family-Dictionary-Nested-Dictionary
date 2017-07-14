using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("daughter", new Dictionary<string, string>(){
                {"name", "Scarlett"}, {"age", "6"}
            });

            myFamily.Add("son", new Dictionary<string, string>(){
                {"name", "Morgan"}, {"age", "16"}
            });

            foreach ( KeyValuePair<string, Dictionary<string, string>> boo in myFamily)
            {
                Console.WriteLine($"{boo.Value["name"]} is my {boo.Key} and is {boo.Value["age"]} years old");
            }
                
        }
    }
}
