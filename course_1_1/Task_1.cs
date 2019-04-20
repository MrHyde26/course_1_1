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
            var firstOperandString = Task_1.AskForOperand();
            var secondOperandString = Task_1.AskForOperand();

            double firstNumber = Task_1.ParseOperand(firstOperandString);
            double secondNumber = Task_1.ParseOperand(secondOperandString);

            Console.WriteLine("Enter arithmetic sign");
            string arithmeticSign = Console.ReadLine();
            Console.WriteLine (Task_1.Calculation(firstNumber, secondNumber, arithmeticSign));
        }

        private static string AskForOperand()
        {
            Console.WriteLine("Enter operand");
            return Console.ReadLine();
        }


        private static double ParseOperand(string operandString)
        {
            if (double.TryParse(operandString, out double operand))
            {
                return operand;
            }
            else
            {
                throw new ArgumentException("The string cannot be parsed into double");
            }
        }

        private static double Calculation(double firstNumber, double secondNumber, string sign)
        {
            double result = 0;
            switch (sign)
            {
                case "+":
                    result = Task_1.Add(firstNumber, secondNumber);
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

        private static double Add(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber);
        }

        private static double Sub(double firstNumber, double secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        private static double Mul(double firstNumber, double secondNumber)
        {
            return (firstNumber * secondNumber);
        }

        private static double Div(double firstNumber, double secondNumber)
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
