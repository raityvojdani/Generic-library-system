using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// Represents a library that can store various items.
    /// </summary>
    public class Library
    {
        private List<object> _items = new List<object>();

        /// <summary>
        /// Adds an item to the library.
        /// </summary>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <param name="item">The item to add.</param>
        public void AddItem<T>(LibraryItem<T> item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Retrieves all items in the library.
        /// </summary>
        /// <returns>A collection of all items in the library.</returns>
        public IEnumerable<object> GetAllItems()
        {
            return _items;
        }
    }
}
