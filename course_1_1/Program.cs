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
            //HoursInDay();
            //
            //
            //ABetweenC();
            //
            //
            //OddThreeDigit();
            //
            //
            //XYZ();
            //
            //
            //Calculator();
            //
            //
            //HittingGap();
            //
            //
            //Translate();
            //
            //
            //Payment();
            //
            //
            CalculatorWithRepeat();
            //
        }

        public static void HoursInDay()
        {
            Console.WriteLine("Please enter a seconds");
            string strseconds = Console.ReadLine();
            int.TryParse(strseconds, out int seconds);
            int hours = seconds / 3600;
            Console.WriteLine($"Hours {hours}");
        }

        public static void ABetweenC()
        {
            Console.WriteLine("Enter A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void OddThreeDigit()
        {
            string strthreedigit = Console.ReadLine();
            int threedigit = Convert.ToInt32(strthreedigit);
            if (threedigit % 2 == 0 && strthreedigit.Length == 3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void XYZ()
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * 2;
            Console.WriteLine(x);
        }

        public static void Calculator()
        {
            Console.WriteLine("Enter first number");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter arithmetic sign");
            string sign = (Console.ReadLine());
            int result;
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"Result {result}");
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"Result {result}");
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine($"Result {result}");
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        Console.WriteLine($"Result {result}");
                    }
                    else
                    {
                        Console.WriteLine("Can't divided by zero");
                    }
                    break;
                case " ":
                    Console.WriteLine("Error");
                    break;
                default:
                    break;
            }
        }
        public static void HittingGap()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = "";
            if (0 <= number && number <= 14)
            {
                result += "Number entered in gap 0-14";
            }
            if (15 <= number && number <= 35)
            {
                result += "Number entered in gap 15-35";
            }
            if (36 <= number && number <= 50)
            {
                result += "Number entered in gap 36-50"; ;
            }
            if (50 <= number && number <= 100)
            {
                result += " Number entered in gap 50-100";
            }
            else
            {
                result += "Number doesnt enter into one interval";
            }
            Console.WriteLine(result);

        }
        public static void Translate()
        {
            Console.WriteLine("Enter word in russian");
            string word = Console.ReadLine();
            switch (word)
            {
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "ветер":
                    Console.WriteLine("wind");
                    break;
                case "снег":
                    Console.WriteLine("snow");
                    break;
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "погода":
                    Console.WriteLine("weather");
                    break;
                case "лето":
                    Console.WriteLine("summer");
                    break;
                case "зима":
                    Console.WriteLine("winter");
                    break;
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                case "жарко":
                    Console.WriteLine("hot");
                    break;
                default:
                    Console.WriteLine("This word is not on the dictionary");
                    break;
            }
        }
        public static void Payment()
        {
            Console.WriteLine("Enter your work experience");
            int experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter payment");
            double payment = Convert.ToInt32(Console.ReadLine());
            double bonus = 0;
            if (experience < 5)
            {
                bonus = payment * 0.10;
            }
            if (experience >= 5 && experience < 10)
            {
                bonus = payment * 0.15;
            }
            if (experience >= 10 && experience < 15)
            {
                bonus = payment * 0.25;
            }
            if (experience >= 15 && experience < 20)
            {
                bonus = payment * 0.35;
            }
            if (experience >= 20 && experience < 25)
            {
                bonus = payment * 0.45;
            }
            if (experience >= 25)
            {
                bonus = payment * 0.50;
            }
            Console.WriteLine($"Bonus = {bonus}$");
            Console.WriteLine($"Payment = {payment}$");
            Console.WriteLine($"Expetience = {experience} year");
        }
        public static void CalculatorWithRepeat()
        {
            string repeat="";
            do
            {
            Console.WriteLine("Enter first number");
            string stroperand1= Console.ReadLine();
                
                int operand1;
                if (!int.TryParse(stroperand1, out operand1))
                {
                    repeat = "Y";
                    Console.WriteLine("Error. This not number. Please Enter number.");
                    continue;
                }
                Console.WriteLine("Enter second number");
                string stroperand2 = Console.ReadLine();
                int operand2;
                if (!int.TryParse(stroperand2, out operand2))
                {
                    repeat = "Y";
                    Console.WriteLine("Error. This not number. Please Enter number.");
                    continue;
                }
                Console.WriteLine("Enter arithmetic sign");
            string sign = (Console.ReadLine());
            int result;
                switch (sign)
                {
                    case "+":
                        result = operand1 + operand2;
                        Console.WriteLine($"Result {result}");
                        break;
                    case "-":
                        result = operand1 - operand2;
                        Console.WriteLine($"Result {result}");
                        break;
                    case "*":
                        result = operand1 * operand2;
                        Console.WriteLine($"Result {result}");
                        break;
                    case "/":
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                            Console.WriteLine($"Result {result}");
                        }
                        else
                        {
                            Console.WriteLine("Can't divided by zero");
                        }
                        break;
                    case " ":
                        Console.WriteLine("Error");
                        break;
                    default:
                        
                        break;
                }
                Console.WriteLine($"Please enter Y for repeat or another key for exit");
                repeat = Console.ReadLine();
            } while (repeat == "Y");
        }
    }
}

