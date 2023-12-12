namespace Book
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();

        public void addBook(Book book)
        {
            Books.Add(book);
        }

        public void removeBook(string title)
        {
            Books.RemoveAll(book => book.Title.Equals(title));
        }

        public Book? searchBook(string title)
        {
            return Books.Find(book => book.Title.Equals(title));
        }

        public void listAvailbleBooks()
        {
            foreach (var item in Books)
            {
                if(item.IsAvailable == true)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
