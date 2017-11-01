using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {

        static void triangleArea(double side, double h)
        {
            double area;
            area = side * h / 2;
            Console.WriteLine("The area of the triangle is {0:0.00}", area);
        }

        static void squareArea(double side)
        {
            double area;
            area = side * side;
            Console.WriteLine("The area of the square is {0:0.00}", area);
        }

        static void degreeToRadians(int degree)
        {
            double rad;
            const double pi = Math.PI;
            rad = (pi / 180) * degree;
            Console.WriteLine("Your degrees in radians are: " + rad);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians)");
            string figureChoice = Console.ReadLine();
            if (figureChoice == "triangle")
            {

                Console.WriteLine("Enter side: ");
                double trSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                double trHeight = double.Parse(Console.ReadLine());
                triangleArea(trSide, trHeight);
            }


            if (figureChoice == "square")
            {

                Console.WriteLine("Enter side: ");
                double sqSide = double.Parse(Console.ReadLine());
                squareArea(sqSide);
            }

            if (figureChoice == "radians")
            {
                Console.WriteLine("Enter degrees you want to transfer to radians: ");
                int degree = int.Parse(Console.ReadLine());
                degreeToRadians(degree);
            }

        }
    }
}
