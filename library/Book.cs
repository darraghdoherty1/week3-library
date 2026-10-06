using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace library
{
    class Book
    {
       private string title;
       private string author;
       private string isbn;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }
        public string ISBN
        {
            get { return isbn; }
            set
            { if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}





