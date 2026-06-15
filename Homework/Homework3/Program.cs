using LibrarySimulation;

Console.WriteLine(" ბიბლიოთეკა \n");

Library centralLibrary = new();

centralLibrary.AddBook(new Book("ვეფხისტყაოსანი", "შოთა რუსთაველი", 1200));
centralLibrary.AddBook(new Book("დიდოსტატის მარჯვენა", "კონსტანტინე გამსახურდია", 1939));
centralLibrary.AddBook(new Book("სამოსელი პირველი", "გურამ დოჩანაშვილი", 1975));

centralLibrary.DisplayCatalog();

Console.WriteLine("--- გასესხების პროცესი ---");
centralLibrary.BorrowBook("სამოსელი პირველი");
centralLibrary.BorrowBook("სამოსელი პირველი");

// კატალოგის შემოწმება
centralLibrary.DisplayCatalog();

// წიგნის დაბრუნება
Console.WriteLine("--- დაბრუნების პროცესი ---");
centralLibrary.ReturnBook("სამოსელი პირველი");
centralLibrary.BorrowBook("სამოსელი პირველი");

// წიგნის ამოშლა
Console.WriteLine("\n--- წიგნის წაშლის პროცესი ---");
centralLibrary.RemoveBook("დიდოსტატის მარჯვენა");

// საბოლოო კატალოგის სტატუსი
centralLibrary.DisplayCatalog();


namespace LibrarySimulation
{
    public class Library
    {
        private readonly List<Book> _booksList = [];

        // 1. წიგნის დამატება
        public void AddBook(Book book)
        {
            _booksList.Add(book);
            Console.WriteLine($" წიგნი '{book.Title}' დაემატა ბაზაში.");
        }

        // 2. წიგნის ამოშლა სახელის მიხედვით
        public bool RemoveBook(string title)
        {
            var bookToRemove = _booksList.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                _booksList.Remove(bookToRemove);
                Console.WriteLine($" წიგნი '{title}' ამოიშალა კატალოგიდან.");
                return true;
            }
            Console.WriteLine($"შეცდომა: წიგნი '{title}' ვერ მოიძებნა წასაშლელად.");
            return false;
        }

        // 3. წიგნის გასესხება სახელის მიხედვით
        public void BorrowBook(string title)
        {
            var book = _booksList.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Borrow();
            }
            else
            {
                Console.WriteLine($" შეცდომა: წიგნი '{title}' ჩვენს კატალოგში არ არსებობს.");
            }
        }

        // 4. წიგნის დაბრუნება სახელის მიხედვით
        public void ReturnBook(string title)
        {
            var book = _booksList.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Return();
            }
            else
            {
                Console.WriteLine($" შეცდომა: წიგნი '{title}' არ ეკუთვნის ამ ბიბლიოთეკას.");
            }
        }

        // მიმდინარე კატალოგის დაბეჭდვა კონსოლში
        public void DisplayCatalog()
        {
            Console.WriteLine("\n ბიბლიოთეკის მიმდინარე სტატუსი ");
            if (_booksList.Count == 0)
            {
                Console.WriteLine("ბიბლიოთეკა ცარიელია.");
            }
            else
            {
                foreach (var book in _booksList)
                {
                    string aviability;
                    if (book.IsAvailable)
                    {
                        aviability = "ადგილზეა";
                    }
                    else
                    {
                        aviability = "არ არის ადგილზე"; 
                    }
                    string status = aviability;
                    Console.WriteLine($"- '{book.Title}' | ავტორი: {book.Author} ({book.Year}) -> სტატუსი: {status}");
                }
            }
        }
    }
}