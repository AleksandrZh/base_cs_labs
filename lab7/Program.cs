namespace lab7_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] book = new Book[5];

            book[0] = new Book("Мастер и Маргарита", "М.Булгаков", 842, 1967);
            book[1] = new Book("12 стульев", "Е.Ильф", 448, 1928);
            book[2] = new Book("Мертвые души", "Н.Гоголь", 560, 2022);
            book[3] = new Book("Братья карамазовы", "Ф.Достоевский", 734, 1989);
            book[4] = new Book("Тихий дон", "М.Шолохов", 978, 1975);

            Array.Sort(book);

            for (int i = 0; i < book.Length; i++)
            {
                book[i].Show();
            }
        }
    }
}