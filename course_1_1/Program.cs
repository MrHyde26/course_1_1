using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkWithNumber();
        }
        public static void WorkWithNumber()
        {
            double number = Convert.ToDouble(Console.ReadLine());
            double counter = 0;
            for (double i = 1; i <= Math.Abs(number); i++)
            {
                if (number % i==0) counter+=1;
            }
            if (counter == 2)
            {
                Console.WriteLine("You entered a prime number");
            }
            else
            {
                Console.WriteLine("you");
            }
        }

    }
}
