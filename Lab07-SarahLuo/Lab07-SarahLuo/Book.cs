using System;
namespace Lab07SarahLuo
{
    public class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public int Year { get; set; }

        public Book(String title = "", String author = "", int year = 0){
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
           
        public void Display(){
            Console.WriteLine("{0}, by {1}", Title, Author);
        }
    }
}
