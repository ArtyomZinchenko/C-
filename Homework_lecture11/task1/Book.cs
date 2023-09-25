// Создайте классы Book, Library
// Необходимо хранить данные: Автор, Название, Издательство, Год, Количество страниц. 
// Создать массив объектов. Вывести:
// - список книг заданного автора;
// - список книг, выпущенных заданным издательством;
// - список книг, выпущенных после заданного года.


public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string Publisher { get; }
    public int Year { get; }
    public int Pages { get; }

    public Book(string author, string title, string publisher, int year, int pages)
    {
        Author = author;
        Title = title;
        Publisher = publisher;
        Year = year;
        Pages = pages;
    }
}


