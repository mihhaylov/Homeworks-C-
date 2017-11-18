using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNum = 999 * 999;
            double number;
            double sqrtNum;
            double monthBonus = 0;

            for (int i = 1; i < 31; i++)
            {
                number = random.Next(1, maxNum);
                sqrtNum = Math.Sqrt(number);
                Console.WriteLine("{0:0.0000} is the number for day {1}", sqrtNum, i);

                if (sqrtNum >= 1 && sqrtNum <= 300)
                {
                    sqrtNum *= 5.1;
                    Console.WriteLine("Bonus is: " + sqrtNum);
                    monthBonus += sqrtNum;

                }
                else if (sqrtNum >= 301 && sqrtNum <= 600)
                {
                    sqrtNum *= 10.098;
                    Console.WriteLine("Bonus is: " + sqrtNum);
                    monthBonus += sqrtNum;

                }
                else if(sqrtNum > 601 && sqrtNum <= 999)
                {
                    sqrtNum *= 100.00001;
                    Console.WriteLine("Bonus is: " + sqrtNum);
                    monthBonus += sqrtNum;
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Monthly bonus: {0:0.0000}\n", monthBonus);

            double yearBonus = monthBonus * 12;
            if (yearBonus > 1000000)
            {
                Console.WriteLine("The year bonus is {0} and it is more than a million.", yearBonus);
            }
            else
            {
                Console.WriteLine("The year bonus is {0} and it is less than a million.", yearBonus);
            }

        }
    }
}
