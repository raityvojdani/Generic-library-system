using System;

namespace ConsoleApp1
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method that executes when the application starts.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            // Create library
            Library library = new Library();

            // Create and add library items
            var bookItem = new LibraryItem<string>("The Great Gatsby");
            var magazineItem = new LibraryItem<string>("National Geographic");
            var dvdItem = new LibraryItem<string>("Inception DVD");

            library.AddItem(bookItem);
            library.AddItem(magazineItem);
            library.AddItem(dvdItem);

            // Retrieve and display all items in the library
            Console.WriteLine("Items in the Library:");
            foreach (var item in library.GetAllItems())
            {
                Console.WriteLine(item);
            }
        }
    }
}
