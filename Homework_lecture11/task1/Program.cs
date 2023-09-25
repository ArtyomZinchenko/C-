// Создайте классы Book, Library
// Необходимо хранить данные: Автор, Название, Издательство, Год, Количество страниц. 
// Создать массив объектов. Вывести:
// - список книг заданного автора;
// - список книг, выпущенных заданным издательством;
// - список книг, выпущенных после заданного года.
 
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Homework_lecture11;

class Program
{
    static void Main(string[] args)
    {
        Book[] books =
        {
            new("George Orwell","1984", "Secker & Warburg", 1949, 328 ),
            new ("J.K. Rowling", "Harry Potter and the Philosopher's Stone", "Bloomsbury", 1997, 223),
            new("George Orwell", "The animal farm", "Penguin", 1945, 210)
        };

        Library library = new(books);
        library.GetBooksByAuthor("GeOrGe OrWeLl");
        library.GetBooksByPublisher("penguin");
        library.GetBooksAfterYear(1945);
    }
}

