using System;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double rad;
            Console.WriteLine("Calculation of a circle area!");
            Console.WriteLine("");
            Console.WriteLine("Enter the radius of your circle: ");
            rad = double.Parse(Console.ReadLine());
            //double fromFunction = Circle(rad);
            Console.WriteLine($"The Area of your Circle is {Circle(rad)}");
            Console.WriteLine("------------------------------------------------------");
            double side1;
            double side2;
            double area;
            Console.WriteLine("\nCalculation of a square area!");
            Console.WriteLine("");
            Console.WriteLine("Enter the measurements of one of the square sides: ");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the measurements of the other square side: ");
            side2 = double.Parse(Console.ReadLine());
            area = Square(side1, side2);
            Console.WriteLine($"The area of your sqare is {area}");
            Console.ReadLine();

        }
        static double Circle(double rad)
        {
            return rad = Math.PI * rad * rad;
            //
            //Console.ReadLine();
        }
        static double Square(double side1, double side2)
        {
            return side1 * side2;
            //
            //Console.ReadLine();
        }
    }
}
