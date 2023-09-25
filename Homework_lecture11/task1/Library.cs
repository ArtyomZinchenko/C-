namespace Homework_lecture11;

public class Library
{
    private Book[] _books;

    public Library(Book[] books) => _books = books;

    public void GetBooksByAuthor(string author)
    {
        Console.WriteLine($"Books by {author.ToUpper()}:");
        foreach (Book book in _books)
        {
            if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(book.Title);
            }
        }
    }
    
    public void GetBooksByPublisher(string publisher)
    {
        Console.WriteLine($"Books by {publisher.ToUpper()}:");
        foreach (Book book in _books)
        {
            if (book.Publisher.Equals(publisher, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(book.Title);
            }
        }
    }

    public void GetBooksAfterYear(int year)
    {
        Console.WriteLine("Books published after 1945:");
        foreach (Book book in _books)
        {
            if (book.Year > year)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}