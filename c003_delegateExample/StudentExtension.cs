using c002_loopFindExample;

namespace c003_delegateExample
{
    public delegate bool FindStudent(Student std);
    public class StudentExtension
    {
        public static Student[] where(Student[] stdArray, FindStudent del)
        {
            int i=0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }

            return result;
        } 
    }
}