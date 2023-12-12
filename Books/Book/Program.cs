namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Library library = new Library();

            library.addBook(new Book("Фактор Черчилля. Як одна людина змінила історію.", "Боріс Джонсон", 2019, true));
            library.addBook(new Book("Підземна залізниця", "Колсон Вайтхед", 2017, true));
            library.addBook(new Book("Іди туди, де страшно. І матимеш те, про що мрієш.", "Джим Ловлесс", 2022, true));

            library.removeBook("Фактор Черчилля. Як одна людина змінила історію.");
            Console.WriteLine("Видалення книжки \"Фактор Черчилля. Як одна людина змінила історію.\":");
            library.listAvailbleBooks();

            Console.WriteLine("\nПошук книги \"Підземна залізниця\": ");
            var findBook = library.searchBook("Підземна залізниця");
            Console.WriteLine(findBook);

            Console.WriteLine("\nВзяв книжку \"Іди туди, де страшно. І матимеш те, про що мрієш.\"");
            var takeBook = library.searchBook("Іди туди, де страшно. І матимеш те, про що мрієш.");
            takeBook.borrow();

            Console.WriteLine("Доступні книги: ");
            library.listAvailbleBooks();

            Console.WriteLine("\nПовернув книжку \"Іди туди, де страшно. І матимеш те, про що мрієш.\"");
            takeBook.returnBook();

            Console.WriteLine("Доступні книги: ");
            library.listAvailbleBooks();

            Console.ReadKey();
        }
    }
}