using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Book
    {
        public string Title;
        public string Author;
        public int ISBN;

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        // Parameterized constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }
    }
}
