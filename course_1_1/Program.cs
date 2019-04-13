﻿using System;
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
            //Work with Array: max, min, average and odd numbers
            //WorkWithMass();

            //DelDuplicate();

            //
            //IndexArray();
            MoreThanAvarage();
        }


        public static void WorkWithMass()
        {
            Console.WriteLine("Enter size of massive");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
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
                sum += mass[i];
                if (mass[i] % 2 > 0)
                {
                    odd += $"{mass[i]} ";
                }
            }
            average = average / n;
            Console.WriteLine($"\nMax - {max}");
            Console.WriteLine($"Min - {min}");
            Console.WriteLine($"Average - {average}");
            Console.WriteLine($"Sum - {sum}");
            Console.WriteLine(odd);
        }
        public static void DelDuplicate()
        {
            Console.WriteLine("Enter size of massive");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            Random rand = new Random();
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                mass[i] = rand.Next(0, 15);
                Console.Write($"{mass[i]} ");
            }

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j] != mass[j + 1])
                    {
                        counter++;
                    }
                }
            }
            int[] newArray = new int[counter];
            Console.WriteLine();
            Console.WriteLine($"\n{counter}");
            Console.WriteLine();
            for (int i =0; i < mass.Length; i++)
            {
                if (mass[i] != mass[i + 1])
                {
                    newArray[i] = mass[i];
                }
            }
            foreach (var item in newArray)
            {
                Console.Write($"{item} ");
            }
        }
        public static void IndexArray()
        {
            Console.WriteLine("Enter size of massive");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number min");
            int numberMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number max");
            int numberMax = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                mass[i] = rand.Next(0, 100);
                Console.Write($"{mass[i]} ");
            }

            for (int i = 0; i < size; i++)
            {
                if (mass[i] < numberMax && mass[i] > numberMin)
                {
                    Console.Write($"\n{i}");
                }
            }
        }
        public static void MoreThanAvarage()
        {
            Console.WriteLine("Enter size of massive");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            int average = 0;
            string moreThanAvarage = "More Than Avarage: ";
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                mass[i] = rand.Next(0, 100);
                Console.Write($"{mass[i]} ");
            }

            for (int i = 0; i < n; i++)
            {
                average += mass[i];
            }
            average = average / n;
            Console.WriteLine($"\nAverage: {average}");

            for (int i = 0; i < n; i++)
            {
                if (average < mass[i])
                {
                    moreThanAvarage += $"{mass[i]} ";
                }
            }
            Console.WriteLine(moreThanAvarage);
        }
    }
}
