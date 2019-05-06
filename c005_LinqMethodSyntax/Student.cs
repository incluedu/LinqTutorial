using System;

namespace c005_LinqMethodSyntax
{
    public class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return StudentName;
        }
    }
}