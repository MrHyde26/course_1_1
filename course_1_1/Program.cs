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

            //
            //WorkWithNumber();
            //
            //
            //DelNumeral();
            //
            //
            EvenNumbers();
            //
        }
        public static void WorkWithNumber()
        {
            Console.WriteLine("Enter number");
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
        public static void DelNumeral()
        {
            Console.WriteLine("Add number");
            string strnumbeer = Console.ReadLine();
            int number = Convert.ToInt32(strnumbeer);
            int n;
            string strnewNumb = "";
            string result = "";
            Console.WriteLine("Enter numeral for del");
            int del = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < strnumbeer.Length; i++)
            {
                n = number % 10;
                number /= 10;
                if (n != del)
                {
                    strnewNumb += n.ToString();
                }
            }
            int newNumb=Convert.ToInt32(strnewNumb);
            for (int i = 0; i < strnewNumb.Length; i++)
            {
                n = newNumb % 10;
                newNumb /= 10;
                result += n.ToString();
                
            }
            Console.WriteLine(result);
        }
        public static void EvenNumbers()
        {
            Console.WriteLine("Add number");
            string strnumbeer = Console.ReadLine();
            int number = Convert.ToInt32(strnumbeer);
            int n;
            int counter = 0;
            for (int i = 0; i < strnumbeer.Length; i++)
            {
                n = number % 10;
                number /= 10;
                if (n %2== 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Including {counter} even numeral");
        }
    }
}
