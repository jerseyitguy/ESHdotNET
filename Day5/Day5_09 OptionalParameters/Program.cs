//Optional parameters in C#

/*In C#, optional parameters allow you to omit some arguments when 
 * calling a method, using default values for those parameters. 
 * This can simplify method calls and provide flexibility in how 
 * you use methods.*/



using System;


namespace Day5_09_OptionalParameters
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        // Constructor
        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        // Method to display book details with optional parameters
        public void DisplayDetails(bool includeTitle = true, bool includeAuthor = true, bool includeYear = true)
        {
            if (includeTitle)
            {
                Console.WriteLine($"Title: {Title}");
            }
            if (includeAuthor)
            {
                Console.WriteLine($"Author: {Author}");
            }
            if (includeYear)
            {
                Console.WriteLine($"Publication Year: {PublicationYear}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a Book instance
            Book myBook = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);

            // Display all details
            Console.WriteLine("All details:");
            myBook.DisplayDetails();
            Console.WriteLine();

            // Display title and author only
            myBook.DisplayDetails(true,false,true);
            Console.WriteLine("Title and Author only:");
            myBook.DisplayDetails(includeYear: false);
            Console.WriteLine();

            // Display title only Named Argument
            Console.WriteLine("Title only:");
            myBook.DisplayDetails(includeAuthor: false, includeYear: false);
            Console.WriteLine();

            // Display author and publication year only
            Console.WriteLine("Author and Publication Year only:");
            myBook.DisplayDetails(includeTitle: false);
        }
    }
}
