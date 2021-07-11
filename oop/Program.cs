using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Dive Deep Into C#";
            book1.author = "Babatunde Koiki";
            book1.pages = 999;

            Book book2= new Book();
            book2.title = "Dive Deep Into C++";
            book2.author = "Babatunde M Koiki";
            book2.pages = 5999;
            Console.WriteLine(book1.author);
            Console.WriteLine(book2.author);
        }
    }
}
