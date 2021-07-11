using System;

namespace oop {
    /// <summary>
    /// A Book Class
    /// @params title: Title of the book
    /// @params author: Author of the book
    /// @params pages: Number of pages of the book.
    /// <code>Book book1 = new Book("Title", "author author", 1000)</code>
    /// </summary>
    class Book {
        public string title;
        public string author;
        public int pages;

        public Book(string title_, string author_, int pages_) {
            Console.WriteLine("Creating Book");
            title = title_;
            author = author_;
            pages = pages_;
        }
    }
}
