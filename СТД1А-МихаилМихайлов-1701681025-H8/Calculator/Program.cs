using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate some numbers?");
            string answer = Console.ReadLine();

            while (answer != "yes")
            {
                Console.WriteLine("Do you want to calculate some numbers?");
                answer = Console.ReadLine();
            }


            Console.WriteLine("First number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Secound number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation: ");
            char oper = char.Parse(Console.ReadLine());

            if(oper == '+')
            {
                double sum;
                sum = (a + b) * 0.1 ;
                Console.WriteLine("The sum is: " + sum);
            }
            else if (oper == '-')
            {
                double minus;
                minus = Math.Pow(Math.Max(a, b), 2) - Math.Min(a,b) ;
                Console.WriteLine("The sum is: " + minus);
            }
            else if (oper == '*')
            {
                double multiply;
                multiply = a * Math.Sqrt(b);
                Console.WriteLine("The sum is: " + multiply);
            }
            else if (oper == '/')
            {
                double divide;
                if(b == 0)
                {
                    Console.WriteLine("You cannot divide by 0!");
                }
                else
                {
                    divide = a / b;
                    Console.WriteLine("The division equals to: " + divide);

                }

            }

        }
    }
}
