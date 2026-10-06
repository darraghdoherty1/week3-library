using library;
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Methods and classes", "Microsoft", "7654321");
        Console.WriteLine("Currently available books:");
        book.DisplayInfo();
        book1.DisplayInfo();

        Member member = new Member(1, "John smith", "1 High St", 0790090909);
        Member member1 = new Member(2, "Jane Doe", "2 Low St", 0790090908);
        Member invalidMember = new Member(-5, "Rob0t C0p", "50 Main Street", 0781122334);

        Console.WriteLine("Current library members:");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}