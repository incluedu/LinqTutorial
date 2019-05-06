using System;
using System.Collections.Generic;
using System.Linq;

namespace c004_LinqQuerySyntaxExample
{
    /**
     * https://www.tutorialsteacher.com/linq/linq-query-syntax
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };


            IEnumerable<string> result = 
                from s in stringList
                where s.Contains("Tutorials")
                select s;


            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }
    }
}