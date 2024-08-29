# Generic Library System

This project is a simple generic library system implemented in C#. The purpose of this system is to demonstrate the usage of generics in C# by creating a library that can store and manage different types of items.

## Core Components

The core components of this project include:

1. **Library.cs**: This file defines the `Library` class, which is responsible for managing the collection of library items. It includes methods to add items to the library and retrieve all items.

2. **LibraryItem.cs**: This file defines the `LibraryItem` class, which represents an item in the library. It is a generic class that can store any type of item.

3. **Program.cs**: This file contains the main program that demonstrates the usage of the library system. It creates a library, adds items to it, and retrieves and displays all items.

## Setup Instructions

To set up the project, follow these steps:

1. Clone the repository to your local machine.
2. Open the `ConsoleApp1.sln` solution file in Visual Studio.
3. Build the project by selecting `Build` > `Build Solution` from the menu.
4. Run the project by selecting `Debug` > `Start Debugging` from the menu.

## Usage Example

Here is an example of how to use the library system:

```csharp
using System;

namespace ConsoleApp1
{
    internal class Program
    {
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
```

In this example, we create a library and add three items to it: a book, a magazine, and a DVD. We then retrieve and display all items in the library.
