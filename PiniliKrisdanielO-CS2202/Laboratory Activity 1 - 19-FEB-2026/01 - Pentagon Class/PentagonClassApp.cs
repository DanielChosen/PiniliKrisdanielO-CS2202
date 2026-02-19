using System;

namespace PentagonClassApp
{
    class Pentagon
    {
        private double side;

        public Pentagon(double sideLength)
        {
            side = sideLength;
        }

        public double GetPerimeter()
        {
            return 5 * side;
        }

        public double GetArea()
        {
            double factor = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));
            return 0.25 * factor * side * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pentagon p1");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.Write("Side length: ");
            double sideLength1 = double.Parse(Console.ReadLine());

            Pentagon p1 = new Pentagon(sideLength1);

            Console.WriteLine("Perimeter: " + p1.GetPerimeter().ToString("0.000"));
            Console.WriteLine("Area: " + p1.GetArea().ToString("0.000"));

            Console.WriteLine();

            Console.WriteLine("Pentagon p2");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.Write("Side length: ");
            double sideLength2 = double.Parse(Console.ReadLine());

            Pentagon p2 = new Pentagon(sideLength2);

            Console.WriteLine("Perimeter: " + p2.GetPerimeter().ToString("0.000"));
            Console.WriteLine("Area: " + p2.GetArea().ToString("0.000"));
        }
    }
}
