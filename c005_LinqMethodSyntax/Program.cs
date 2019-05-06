using System;
using System.Collections.Generic;
using System.Linq;

namespace c005_LinqMethodSyntax
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string collection
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };

            // LINQ Query Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));

            foreach (var value in result) Console.WriteLine(value);


            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 13},
                new Student() {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student() {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student() {StudentID = 5, StudentName = "Ron", Age = 15}
            };

// LINQ Method Syntax to find out teenager students
            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                .ToList<Student>();

           
            foreach (var value in studentList) Console.WriteLine(value);
        }
    }
}