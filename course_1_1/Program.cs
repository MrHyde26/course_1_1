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
            WorkWithMass();
        }

        public static void WorkWithMass()
        {
            Console.WriteLine("Enter size of massive");
            int n = Convert.ToInt32(Console.ReadLine());
            int []mass = new int [n];
            int average = 0;
            int sum = 0;
            string odd = "Odd numerals: ";
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                mass[i] = rand.Next(0, 100);
                Console.Write($"{mass[i]} ");
            }

            int max = mass[0];
            int min = mass[0];

            for (int i = 0; i < n; i++)
            {
                if (max < mass[i])
                {
                    max = mass[i];
                }
                if (min > mass[i])
                {
                    min = mass[i];
                }
                average += mass[i];
                sum+= mass[i];
                if (mass[i] % 2 > 0)
                {
                    odd += $"{mass[i]} ";
                }
            }
            average = average / (n - 1);
            Console.WriteLine($"\nMax - {max}");
            Console.WriteLine($"Min - {min}");
            Console.WriteLine($"Average - {average}");
            Console.WriteLine($"Sum - {sum}");
            Console.WriteLine(odd);
        }
    }
}
