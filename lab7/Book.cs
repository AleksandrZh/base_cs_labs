namespace lab7_ex6
{
    internal class Book : IComparable
    {
        private string title;
        private string author;
        private int pages;
        private int year;

        public Book(string title, string author, int pages, int year)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.year = year;
        }

        int IComparable.CompareTo(object? obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }

        public void Show()
        {
            Console.WriteLine($"Книга: {title}\nАвтор: {author}\nГод издания: {year}\nстр.: {pages}\n");

        }
    }
}
