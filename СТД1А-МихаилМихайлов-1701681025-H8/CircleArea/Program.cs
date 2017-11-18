using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndRadius = rnd.Next(33, 187);
            Console.WriteLine("The circle random radius is: {0}", rndRadius);
            const double pi = Math.PI;
            double area = pi * (rndRadius * rndRadius);
            Console.WriteLine("The cirsle area is: {0: 0.00}", area);

        }
    }
}
