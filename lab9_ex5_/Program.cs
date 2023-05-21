namespace lab9_ex5_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double courner;

            Triangle trian = new Triangle(45, 67, 89);
            trian.Show();

            Square square = new Square(2);
            square.Show();

            Circle circle = new Circle(5);
            circle.Show();

            Parallelogram par = new Parallelogram(23, 45, 16);
            par.Show();

            Console.WriteLine($"Реализован механизм поиска соседнего угла в параллелограмме. Введите угол A:");
            par.CournerA = double.Parse(Console.ReadLine());
            par.FindAdjCourner();





        }
    }
}