using library;
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Methods and classes", "Microsoft", "7654321");


        book.DisplayInfo();
        book1.DisplayInfo();
    }
}