namespace lab9_ex5_
{
    internal class Parallelogram : Shape, IAdjacentСornerSearcheble
    {
        private double height;

        public double CournerA { get; set; }

        public Parallelogram(double sideA, double sideB, double height) : base(sideA, sideB)
        {
            this.height = height;


        }
        public Parallelogram()
        {

        }


        public override double Area()
        {
            return sideA * height;
        }

        public override double Perimeter()
        {
            return 2 * (sideA + sideB);
        }





        public override void Show()
        {
            Console.WriteLine($"Параллелограм со сторонами A: {sideA}, B: {sideB} и высотой h: {height}, периметер : {Perimeter()}, площадь: {Area()}\n");
        }



        public void FindAdjCourner()
        {
            Console.WriteLine($"Угол A: {CournerA}, соседний угол B: {180 - CournerA}");
        }
    }
}
