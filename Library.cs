using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Library
    {
        private List<object> _items = new List<object>();

        // Generic method to add items to the library
        public void AddItem<T>(LibraryItem<T> item)
        {
            _items.Add(item);
        }

        public IEnumerable<object> GetAllItems()
        {
            return _items;
        }
    }
}
