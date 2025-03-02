namespace LibraryFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookFactory factory = new BookFactory();

            Console.Write("Please enter your book type (fiction, nonfiction, reference): ");
            string selectedBook = Console.ReadLine();

            IBook book = factory.GetBook(selectedBook);
            Console.WriteLine("Genre: {0}, Author: {1}, Description: {2}",
                book.GetGenre(), book.GetAuthor(), book.GetDescription());
        }
    }
}
