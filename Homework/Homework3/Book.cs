namespace LibrarySimulation;

public class Book
{
    public string Title { get; init; }
    public string Author { get; init; }
    public int Year { get; init; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        IsAvailable = true;
    }

    public bool Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"[წარმატება] წიგნი '{Title}' წარმატებით გაიცემა.");
            return true;
        }

        Console.WriteLine($"[შეცდომა] წიგნი '{Title}' უკვე გასესხებულია სხვაზე!");
        return false;
    }

    public void Return()
    {
        if (!IsAvailable)
        {
            IsAvailable = true;
            Console.WriteLine($"[წარმატება] წიგნი '{Title}' წარმატებით დაბრუნდა ბიბლიოთეკაში.");
        }
        else
        {
            Console.WriteLine($"[ინფორმაცია] წიგნი '{Title}' ისედაც ადგილზეა.");
        }
    }
}