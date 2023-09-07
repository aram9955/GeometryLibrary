using System;
using System.Collections.Generic;
using System.Linq;
using GeometryLibrary;
using System.Threading.Tasks;
using GeometryLibrary.Model;

namespace GeometryLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Area of a circle");
            Console.WriteLine("2. Area of a triangle");
            Console.Write("Choose what you want to calculate: ");

            if (int.TryParse(Console.ReadLine(), out var choice))
            {
                Figure figure = null;

                switch (choice)
                {
                    case 1:
                        figure = new Circle();
                        break;
                    case 2:
                        figure = new Triangle();
                        break;
                    default:
                        Console.WriteLine("Incorrect choice.");
                        break;
                }

                figure.Init();
                figure.PrintArea();
            }
            else
            {
                Console.WriteLine("Incorrect choice.");
            }


            Console.ReadKey();
        }
    }
}
