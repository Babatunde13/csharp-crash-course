using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Dive Deep Into C#", "Babatunde Koiki", 999);

            Book book2= new Book("Dive Deep Into C++", "Babatunde M Koiki", 5999);
            Console.WriteLine(book1.author);
            Console.WriteLine(book2.author);
        }
    }
}
