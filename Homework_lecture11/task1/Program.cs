// Создайте классы Book, Library
// Необходимо хранить данные: Автор, Название, Издательство, Год, Количество страниц. 
// Создать массив объектов. Вывести:
// - список книг заданного автора;
// - список книг, выпущенных заданным издательством;
// - список книг, выпущенных после заданного года.
 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold Library objects
         Library[] myLibraryArray = new Library[3];

        // Create and add some books to the list
        Library book1 = new Library { author = "George Orwell", title = "1984", publisher = "Secker & Warburg", year = 1949, pages = 328 };
        Library book2 = new Library { author = "J.K. Rowling", title = "Harry Potter and the Philosopher's Stone", publisher = "Bloomsbury", year = 1997, pages = 223 };
        Library book3 = new Library { author = "George Orwell", title = "The animal farm", publisher = "Penguin", year = 1945, pages = 210 };

        myLibraryArray[0] = book1;
        myLibraryArray[1] = book2;
        myLibraryArray[2] = book3;

        // Function to find books by a given author
        Console.WriteLine("Books by George Orwell:");
        foreach (Library book in myLibraryArray)
        {
            if (book.author == "George Orwell")
            {
                Console.WriteLine(book.title);
            }
        }

        // Function to find books by a given publisher
        Console.WriteLine("Books by Bloomsbury:");
        foreach (Library book in myLibraryArray)
        {
            if (book.publisher == "Bloomsbury")
            {
                Console.WriteLine(book.title);
            }
        }

        // Function to find books published after a given year
        Console.WriteLine("Books published after 1945:");
        foreach (Library book in myLibraryArray)
        {
            if (book.year > 1945)
            {
                Console.WriteLine(book.title);
            }
        }
    }
}

