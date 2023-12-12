namespace Book
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        public Book() { }
        public Book(string title, string author, int year, bool isAvailable)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }

        public void borrow(){
            IsAvailable = false;
        }
        public void returnBook(){
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"Назва: {Title}, Автор: {Author}, Рік: {Year}";
        }
    }
}
