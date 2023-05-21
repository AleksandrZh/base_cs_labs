namespace lab9_ex5_
{
    internal class Square : Shape, IRotaitble
    {

        public Square(double sideA) : base(sideA)
        {

        }
        public Square()
        {

        }


        public override double Area()
        {
            return Math.Pow(sideA, 2);
        }

        public override double Perimeter()
        {
            return 4 * sideA;
        }

        public override void Show()
        {
            Console.WriteLine($"Квадрат со сторонами : {sideA} см.,   периметер : {Perimeter()}, площадь: {Area()},\n вращение: {Rotate()}\n");
        }

        public string Rotate()
        {
            return $"Интерфейс вращения реализован";
        }


    }
}
