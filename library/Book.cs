using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();

        }
    }
}
