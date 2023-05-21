namespace lab9_ex5_
{
    abstract class Shape
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;
        protected double sideD; // for polygon

        public Shape()
        {

        }

        public Shape(double sideA)// for square
        {
            this.sideA = sideA;
        }

        public Shape(double sideA, double sideB) : this(sideA)
        {

            this.sideB = sideB;
        }

        protected Shape(double sideA, double sideB, double sideC) : this(sideA)
        {
            this.sideB = sideB;
            this.sideC = sideC;

        }

        protected Shape(double sideA, double sideB, double sideC, double sideD) : this(sideA, sideB, sideC)
        {
            this.sideD = sideD;
        }

        abstract public double Perimeter();

        abstract public double Area();

        abstract public void Show();
    }
}
