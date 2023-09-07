using System;

namespace GeometryLibrary.Model
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

        public override void Init()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            if (Radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }

            Radius = radius;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area of a circle with a radius {Radius} equal {CalculateArea()}");
        }
    }
}
