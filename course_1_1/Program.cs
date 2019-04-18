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
            //ArrayUnpacking();

            PerfectNumber();


        }
        public static void ArrayUnpacking()
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2);
                Console.Write(array[i]);
            }

            Console.WriteLine("\nResult");
            for (int i = 0; i < array.Length; i++)
            {
                   for (int j = 1; j < array[i]; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(0);
                        }
                        else
                        {
                            Console.Write(1);
                        }
                    }
            }           
        }

        public static void PerfectNumber()
        {
            int sum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i%j==0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine($"Perfect Number: {sum}");
                }
            }
        }
    }
}
