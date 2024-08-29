namespace ConsoleApp1
{
    /// <summary>
    /// Represents an item in the library.
    /// </summary>
    public class LibraryItem<T>
    {
        /// <summary>
        /// Gets the item stored in the library.
        /// </summary>
        public T Item { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItem{T}"/> class.
        /// </summary>
        /// <param name="item">The item to store in the library.</param>
        public LibraryItem(T item)
        {
            Item = item;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
