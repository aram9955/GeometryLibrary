using System;

namespace GeometryLibrary.Model
{
    internal class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override void Init()
        {
            Console.Write("Enter the length of side A of the triangle: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of side B of the triangle: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of side C of the triangle: ");
            double sideC = double.Parse(Console.ReadLine());

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Triangle side lengths must be positive numbers");
            }

            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                throw new ArgumentException("Triangle with given sides is invalid");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area of a triangle with sides {SideA}, {SideB}, {SideC} equal {CalculateArea()}");
        }

        public bool IsRightTriangle()
        {
            double maxSide = Math.Max(SideA, Math.Max(SideB, SideC));

            double aSquared, bSquared;

            if (maxSide == SideA)
            {
                aSquared = SideB * SideB;
                bSquared = SideC * SideC;
            }
            else if (maxSide == SideB)
            {
                aSquared = SideA * SideA;
                bSquared = SideC * SideC;
            }
            else
            {
                aSquared = SideA * SideA;
                bSquared = SideB * SideB;
            }

            return maxSide * maxSide == aSquared + bSquared;
        }
    }
}
