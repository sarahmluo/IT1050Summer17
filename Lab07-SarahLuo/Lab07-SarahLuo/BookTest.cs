using System;

namespace Lab07SarahLuo
{
    class BookTest
    {
        public static void Main(string[] args)
        {
            Book myBook = new Book {Title = "1984", Author = "George Orwell", Year = 1949};
            myBook.Display();

        }
    }
}
