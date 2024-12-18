using System;
using ObjectOrientedDesign;

public class  Program
{
    public static void Main()
    {
        // Create a new library
        Library libary = new Library();

        // Add books to the library
        libary.AddBook(new Book("The Alchemist", "Paulo Coelho"));
        libary.AddBook(new Book("The Da Vinci Code", "Dan Brown"));

        // Show the list of books in the library
        libary.ListBooks();
    }
}
