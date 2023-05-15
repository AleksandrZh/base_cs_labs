namespace lab8_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            int d = 0;
            Triangle trian;
            Console.WriteLine($"Необходимо выбрать тип треугольника: 1 - равносторонний; 2 - разносторонний");
            d = int.Parse(Console.ReadLine());

            if (d == 1)
            {
                Console.WriteLine("Сторона:");
                a = double.Parse(Console.ReadLine());

                trian = new Triangle(a);
                trian.Show();

            }
            else
            {
                Console.WriteLine("Сторона a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Сторона b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Сторона c:");
                c = double.Parse(Console.ReadLine());
                trian = new Triangle(a, b, c);
                trian.Show();

            }



        }
    }
}