namespace lab9_ex5_
{
    internal class Triangle : Shape, IRotaitble
    {

        public Triangle()
        {

        }

        public Triangle(double sideA) : base(sideA)
        {

        }
        public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
        {

        }









        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double Area()
        {
            double p = ((sideA + sideB + sideC) / 2);

            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override void Show()
        {

            Console.WriteLine($"Треугольник со сторонами  A: {sideA} B: {sideB} C: {sideC}  периметер : {Perimeter()}, площадь: {Area()} ,\n вращение: {Rotate()}\n  ");


        }

        public string Rotate()
        {
            return "Интерфейс вращения реализован";
        }
    }
}