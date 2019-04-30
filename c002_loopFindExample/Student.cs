using System;

namespace c002_loopFindExample
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