using System;
using System.Linq;
using c002_loopFindExample;

namespace c003_LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray =
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Steve", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 31},
                new Student {StudentID = 6, StudentName = "Chris", Age = 17},
                new Student {StudentID = 7, StudentName = "Rob", Age = 19}
            };

            // Use LINQ to find teenager students
            Student[] teenAgerStudents = studentArray
                .Where(student => student.Age > 12 && student.Age <= 20 && student.StudentName.Contains("a")).ToArray();

            foreach (var student in teenAgerStudents)
            {
                Console.WriteLine("Student:= " + student);
            }

            // Use LINQ to find first student whose name is Bill 
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            // Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
        }
    }
}