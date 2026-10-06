using library;

Console.WriteLine("Hello, World!");

Book book = new Book();
book.Title = "C# for beginners";
book.Author = "Bill gates";
book.ISBN = "12345678";

book.DisplayInfo();

Book book1 = new Book();
book1.Title = "C# methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55566778";

book1.DisplayInfo();