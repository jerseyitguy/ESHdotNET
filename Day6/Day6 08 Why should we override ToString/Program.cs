//Overriding the ToString() method in a class is a common practice in
//object-oriented programming,
//particularly in C#

namespace Day6_08_Why_should_we_override_ToString
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }

        // Default constructor
        public Book(string title, string author, string isbn, int publicationYear)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }

        // Override the ToString() method
        public override string ToString()
        {
            return $"\"{Title}\" by {Author} (Published in {PublicationYear}, ISBN: {ISBN})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a few book instances
            Book book1 = new Book("1984", "George Orwell", "978-0451524935", 1949);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "978-0061120084", 1960);
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565", 1925);

            // Display the book details using the overridden ToString() method
            // Console.WriteLine($"\"{book1.Title}\" by {book1.Author} (Published in {book1.PublicationYear}, ISBN: {book1.ISBN})");
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
        }
    }

}
