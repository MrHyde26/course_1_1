using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_1_1
{
    public static class Task_1
    {
        public static void PerformCalculation()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter arithmetic sign");
            string arithmeticSign = Console.ReadLine();
            Console.WriteLine (Task_1.Calculation(firstNumber, secondNumber, arithmeticSign));
        }

        private static double Calculation(int firstNumber, int secondNumber, string sign)
        {
            double result = 0;
            switch (sign)
            {
                case "+":
                    result= Task_1.Add(firstNumber, secondNumber);
                    break;
                case "-":
                    result = Task_1.Sub(firstNumber, secondNumber);
                    break;
                case "*":
                    result = Task_1.Mul(firstNumber, secondNumber);
                    break;
                case "/":
                    result = Task_1.Div(firstNumber, secondNumber);
                    break;
            }

            return result;
        }

        private static int Add(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber);
        }

        private static int Sub(int firstNumber, int secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        private static int Mul(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber);
        }

        private static double Div(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                return (firstNumber / secondNumber);
            }
            else
            {
                throw new ArgumentException("We can't divide by zero");
            }
        }
    }
}
