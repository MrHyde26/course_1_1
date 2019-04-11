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
            //Exponentiation();
            //
            //
            //ProductRoute();
            //
            //
            //DrowFigure();
            //
            //
            //FibonachiNumberLessThan();
            //
            //
            //FirstNumbersFibonachi();
            //
            //////////DrawPyramid();
            //
            //
            //SumRow();
            //
            //BetweenNumbers();
            //
            SquareLessThanNumber();
            //
        }
        static void DrawPyramid()
        {
            int n = 5;
            int m = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= m; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
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
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0) counter += 1;
                }
                if (counter == 1)
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
        public static void ProductRoute()
        {
            Console.WriteLine("Add number of clients");
            int clients = Convert.ToInt32(Console.ReadLine());
            int n=1;
            int result=1;
            do
            {
                result *= n;
                n++;
            } while (n<=clients);
            Console.WriteLine($"Number of possible routes: {result}");
        }
        public static void DrowFigure()
        {
            int length = 8;
            int high = 9;
            //
            //line
            //
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            //
            //right triangle
            //
            for (int i = 0; i < length; i++)
            {
                Console.Write("\n*");
                for (int j = 0; j < high - 1; j++)
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
            //
            //rectangle with frames
            //
            for (int i = 0; i < length; i++)
            {
                Console.Write("\n*");
                for (int j = 0; j < high - 1; j++)
                {
                    if (i == 0 || i == length - 1 || j == high - 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
            //
            //rectangle 
            //
            for (int i = 0; i < length; i++)
            {
                Console.Write("\n*");
                for (int j = 0; j < high - 1; j++)
                    //{
                    Console.Write("*");
            }
            Console.WriteLine();
            //
            //right triangle with frames
            //
            for (int i = 0; i < length; i++)
            {
                Console.Write("\n*");

                for (int j = 0; j < high - 1; j++)
                {
                    if (i > j)
                    {
                        if (j == i - 1 || i == length - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
            //
            //equilateral triangle
            //
            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    Console.Write("\n*");
                }
                else
                {
                    Console.Write("\n ");
                }
                for (int j = 0; j < high - 1; j++)
                {
                    if (i == length - 1 || j == high / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
        public static void FibonachiNumberLessThan()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            Console.WriteLine(fib1);
            Console.WriteLine(fib2);
            for (int i = 0; i <= number; i++)
            {
                fib1 = fib1 + fib2;
                fib2 = fib2 + fib1;
                if (fib1 < number)
                {
                    Console.WriteLine(fib1);
                }
                if (fib2 < number)
                {
                    Console.WriteLine(fib2);
                }
                if (fib1 > number || fib2 > number)
                {
                    break;
                }
            }
        }
        public static void FirstNumbersFibonachi()
        { 
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            for (int i = 0; i<number; i++)
            {
                Console.WriteLine(fib1);
                for (int j = i; j<i+1; j++)
                {
                    int temp = fib1;
                    fib1 = fib2;
                    fib2 = temp + fib2;
                }
            }
        }
        public static void SumRow()
        {
            Console.WriteLine("Enter number");
            double number = Convert.ToDouble(Console.ReadLine());
            double newNumber = 1;
            double result = 0;
            string str = "";
            for (double i = 1; i <= number; i++)
            {
                for (double j = 1; j <= i; j++)
                {
                    newNumber *= -2;
                }
                result += (-1) * i / newNumber;
                str += ($" {i} / {newNumber}").ToString();
                newNumber = 1;
                Console.WriteLine(result);
            }
            Console.WriteLine(str);
        }
        public static void BetweenNumbers()
        {
            bool check = true;
            do
            {
                Console.WriteLine("Enter number A");
                int numberA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number B");
                int numberB = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                string odd = "";
                if (numberA > numberB)
                {
                    Console.WriteLine("Error. A>B. Please try again.");
                    check = false;
                    continue;
                }
                for (int i = numberA + 1; i < numberB; i++)
                {
                    sum += i;
                    if (i % 2 > 0)
                    {
                        odd += $" {i},";
                    }
                }
                Console.WriteLine($"Сумма чисел между {numberA} и {numberB}: {sum}. \nНечётный значения между ними:{odd}");

            } while (check == false);
        }
        public static void SquareLessThanNumber()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i < number; i++)
            {
                result = i * i;
                if (result < number)
                {
                    Console.WriteLine(result);
                }
            }
        }
        public static void MileageSkier()
        {
            double mileage = 10;
            double result = 10;
            int day = 1;
            while (result <= 100)
            {
                mileage = mileage * 1.1;
                result += mileage;
                day++;
            }
            Console.WriteLine(day);
        }
    }
}
