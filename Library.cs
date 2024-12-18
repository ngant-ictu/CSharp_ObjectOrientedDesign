using System;

namespace ObjectOrientedDesign;

public class Library
{
    // List of books in the library
    private List<Book> books;

    // Constructor to initialize the library
    public Library()
    {
        books = new List<Book>(); // Use list to store books better than array
    }

    // Method to add a book to the library
    public void AddBook (Book book)
    {
        books.Add(book);
    }

    // Method to show the list of books in the library
    public void ListBooks() 
    {
        foreach (var book in books)
        {
            book.DisplayInfo(); // Display the details of each book
        }
    }
}
