namespace ConsoleApp1
{
    public class LibraryItem<T>
    {
        public T Item { get; private set; }

        public LibraryItem(T item)
        {
            Item = item;
        }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
