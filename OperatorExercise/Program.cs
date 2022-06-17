using System;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a} / {b} is {div} remainder {mod}");

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Area of circle calculator:");
            Console.WriteLine();
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
        
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
