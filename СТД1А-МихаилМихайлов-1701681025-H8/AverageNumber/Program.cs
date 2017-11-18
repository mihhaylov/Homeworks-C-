using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int evenNum = 0;

            Console.WriteLine("Enter a number in this diapason [1, 255]. Enter 0 to end the input.");

            do
            {
                number = int.Parse(Console.ReadLine());
                    
                if(number >= 1 && number <= 255 && number % 2 == 0)
                {
                    sum += number;
                    evenNum++;
                     }

                
            } while (number !=0);

            if (sum == 0)
                Console.WriteLine("There aren't even numbers in the diapason of [1, 255]");
            else
            {
                int result = sum / evenNum;
                Console.WriteLine("Avarage is: " + result);
            }
            

        }
    }
}
