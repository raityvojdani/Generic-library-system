using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// Represents a library that stores various items.
    /// </summary>
    public class Library
    {
        // List to store library items
        private List<object> _items = new List<object>();

        /// <summary>
        /// Adds a new item to the library.
        /// </summary>
        /// <typeparam name="T">The type of the item being added.</typeparam>
        /// <param name="item">The library item to add.</param>
        public void AddItem<T>(LibraryItem<T> item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Retrieves all the items stored in the library.
        /// </summary>
        /// <returns>An enumerable collection of all library items.</returns>
        public IEnumerable<object> GetAllItems()
        {
            return _items;
        }
    }
}
