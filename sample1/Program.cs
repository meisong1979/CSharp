using test;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Book[] bookArray = new Book[2];
        Book book1 = new Book(10, "aaaa");
        Book book2 = new Book(2, "bbbb");
        bookArray[0] = book1;
        bookArray[1] = book2;
        SortHelper<Book> sorter = new SortHelper<Book>();
        sorter.BubbleSort(bookArray);
        
        bookArray.All((b1) =>
        {
            Console.WriteLine($"Book - Price:{b1.getPrice()}, Title:{b1.getTitle()}");
            return true;
        });
    }
}