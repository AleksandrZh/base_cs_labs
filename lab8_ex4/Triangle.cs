﻿namespace lab8_ex4
{
    internal class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double perimeter;
        private double area;

        public double Area
        {
            get { return area; }

        }


        public Triangle(double sideA)
        {
            this.sideA = sideA;
            this.sideB = sideA;
            this.sideC = sideA;


        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;


        }




        private void CheckExistenceTriangle()
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                perimeter = Perimeter();
                area = AreaT();
                Console.WriteLine($"Треугольник со сторонами  A: {sideA} B: {sideB} C: {sideC} существует. Его периметер : {perimeter}, площадь: {area}");
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами A: {sideA} B: {sideB} C: {sideC} не существует.");
            }
        }

        private double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        private double AreaT()
        {

            double p = ((sideA + sideB + sideC) / 2);

            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public void Show()
        {

            CheckExistenceTriangle();

        }
    }
}
