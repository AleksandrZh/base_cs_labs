namespace lab9_ex5_
{
    internal class Circle : Shape
    {

        private double r;

        public Circle()
        {

        }

        public Circle(double r)
        {
            this.r = r;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public override void Show()
        {
            Console.WriteLine($"Круг с радиусом: {r}, периметер : {Perimeter()}, площадь: {Area()}\n ");
        }
    }
}
