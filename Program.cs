using System;
namespace bookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore book1 = new(1234, "Critique of Pure Reason", "Immanuel Kant", 49.99);
            Bookstore book2 = new(2345, "An Essay Concerning Human Understanding", "John Locke", 59.99);
            Bookstore book3 = new(3456, "Enchiridion", "Epictetus", 29.99);
            Bookstore book4 = new(4567, "If You Give a Mouse a Cookie", "Laura Numeroff", 9.99);
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine(book4);

        }
    }
}
