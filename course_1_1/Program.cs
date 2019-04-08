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
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            string result = "";
            if (number > 0)
            {
                result += "Your number is positive";
            }
            else if (number < 0)
            {
                result += "Your number is negative";
            }
            else
            {
                result += "Your number is zero";
            }

            for (int i = 1; i <= Math.Abs(number); i++)
            {
                if (number % i==0) counter+=1;
            }
            if (counter == 2)
            {
                result += "\nYou entered a prime number";
                
            }
            else
            {
                result += "\nYou entered not a prime number";
            }
            int []setDivide=new int[] { 2, 3, 5, 6, 9 };
            for (int i = 0; i < setDivide.Length; i++)
            {
                if (number % setDivide[i]==0)
                {
                    result += $"\nThe entered number is divisible by {setDivide[i]} without remainder";
                }
            }
            Console.WriteLine(result);
        }

    }
}
