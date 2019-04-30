using System;
using System.Linq;

namespace c001_firstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source
            string[] names = {"Bill", "Steve", "James", "Mohan", "Patric", "Monika", "Kevin", "Pornanan"};

            // LINQ Query 
            var myLinqQuery = from name in names
                where name.Contains('a')
                select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }
    }
}