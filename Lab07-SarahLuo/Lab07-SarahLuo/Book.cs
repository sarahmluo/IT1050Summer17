using System;
namespace Lab07SarahLuo
{
    public class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public int Year { get; set; }

        public Book(){}
           
        public void Display(){
            Console.WriteLine("{0}, by {1}", Title, Author);
        }
    }
}
