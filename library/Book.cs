using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Book
    {



        // Private fields 
        private string _title;

        private string _author;

        private string _isbn;


        // Public properties 
        public string title
        {
            get { return _title; }
            set {
                // Check if any incoming char i a digit
                if (value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter number for the title");
                }

            }
        }

        public string author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        // Constructor

        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        // Methods 

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        public string Title;
        public string Author;
        public int ISBN;
        }
    }
