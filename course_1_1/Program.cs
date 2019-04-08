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
            //EvenNumbers();
            //
            //
            //Average();
            //
            //
            //RandomNumber();
            //
            //
            Exponentiation();
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
                for (int i = 2; i <= Math.Abs(number); i++)
                {
                    if (number % i == 0) counter += 1;
                }
                if (counter == 2)
                {
                    result += "\nYou entered a prime number";

                }
                else
                {
                    result += "\nYou entered not a prime number";
                }
            }
            else if (number < 0)
            {
                result += "Your number is negative \nYou entered not a prime number";
                
            }
            else
            {
                result += "Your number is zero";
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
        public static void Average()
        {
            bool check = false;
            do
            {
                
                Console.WriteLine("Add number A");
                int numberA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add number B");
                int numberB = Convert.ToInt32(Console.ReadLine());
                if (numberA > numberB)
                {
                    Console.WriteLine("Initial number is greater than the final. Please try again");
                    check = true;
                    continue;
                }
                int sum = 0;
                int counter = 0;
                int average;
                for (int i = numberA; i <= numberB; i++)
                {
                    sum += i;
                    counter++;
                }
                average = sum / counter;
                Console.WriteLine($"Average = {average} \nInput Y to repeat");
                string repeat= Console.ReadLine();
                if (repeat == "Y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            } while (check);
           
        }
        public static void RandomNumber()
        {
            bool check = false;
            int number = new Random().Next(1,100);
            int ourNumber = 0;
            do
            {
                Console.WriteLine("Enter Number:");
                ourNumber = Convert.ToInt32(Console.ReadLine());
                if (ourNumber > number)
                {
                    Console.WriteLine("Less");
                    check = true;
                }
                else if (ourNumber < number)
                {
                    Console.WriteLine("More");
                    check = true;
                }
                else
                {
                    Console.WriteLine($"Congratulations! Random number is {number}");
                    check = false;
                } 
            } while (check);         
        }
        public static void Exponentiation()
        {
            Console.WriteLine("Add number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add exponent");
            int exponent = Convert.ToInt32(Console.ReadLine());
            int result=1;
            for (int i = 1; i <= exponent; i++)
            {
                result *= number;
            }   
            Console.WriteLine(result);
        }
    }
}
