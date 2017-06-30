using System;

namespace Discovery
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GradeBook grades = new GradeBook("IT 1050");

            Console.WriteLine("CourseName: {0}", grades.CourseName);
        }
    }
}
