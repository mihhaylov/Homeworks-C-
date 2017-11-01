using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getMax
{
    class Program
    {
        static void getMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is: " + b);
            }
            else
            {
                Console.WriteLine("The biggest number is: " + c);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("enter 1st number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 2nd number: ");
            int secound = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 3rd number: ");
            int third = int.Parse(Console.ReadLine());

            getMax(first, secound, third);


        }
    }
}
