using System;
namespace Discovery
{
    public class GradeBook
    {
        private String name;

        public String CourseName { 
            get{
                return name;
            } 
            set{
                name = value;
            } 
        }

        public GradeBook(String name){
            CourseName = name;
        }
    }
}
