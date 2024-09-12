namespace ConsoleApp1
{
    /// <summary>
    /// Represents a generic library item.
    /// </summary>
    /// <typeparam name="T">The type of the library item.</typeparam>
    public class LibraryItem<T>
    {
        /// <summary>
        /// Gets the item stored in the library.
        /// </summary>
        public T Item { get; private set; }

        /// <summary>
        /// The item to store in the library
        /// </summary>
        public LibraryItem(T item)
        {
            Item = item;
        }

        /// <summary>
        /// Returns a string that represents the current library item.
        /// </summary>
     
        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
