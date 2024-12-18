using System;

namespace ObjectOrientedDesign;

public class Book
{
    // Attributes of a book
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize the book
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Method to display the book details
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
