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
            double area;
            Console.WriteLine("\nCalculation of a square area!");
            Console.WriteLine("");
            Console.WriteLine("Enter the measurements of the square sides: ");
            side1 = double.Parse(Console.ReadLine());
            area = Square(side1);
            Console.WriteLine($"The area of your sqare is {area}");
            Console.ReadLine();

        }
        static double Circle(double rad)
        {
            return rad = Math.PI * rad * rad;
            //
            //Console.ReadLine();
        }
        static double Square(double side1)
        {
            return side1 * side1;
            //
            //Console.ReadLine();
        }
    }
}
