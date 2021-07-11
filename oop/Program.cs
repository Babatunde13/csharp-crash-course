using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Dive Deep Into C#", "Babatunde Koiki", 999);

            Book book2= new Book("Dive Deep Into C++", "Babatunde M Koiki", 5999);

            Student student1 = new Student("Jim", "Business", 3.6);

            Student student2= new Student("Pat", "Art", 2.4);

            // Console.WriteLine(book1.author);
            // Console.WriteLine(book2.author);

            Console.WriteLine(student1.name);
            Console.WriteLine(student2.name);

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
        }
    }
}
