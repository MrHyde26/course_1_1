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
            //Work with Array: max, min, average and odd numbers
            //WorkWithMass();

            //DelDuplicate();

            //
            //IndexArray();
            //MoreThanAvarage();
            Console.WriteLine("Enter size of massive");
            int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Count");
            //int count = Convert.ToInt32(Console.ReadLine());
            

            var array = Program.GetArray(n);

            //MyReverse(array);
            //SubArray(array, index, count);

            //Console.WriteLine("Enter new element of array");        
            //int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter element");
            int x = Convert.ToInt32(Console.ReadLine());

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //IncreaseLength(array, value);
            FoundInArray(array, x);

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

        private static int[] GetArray(int count)
        {
            int[] array = new int[count];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            return array;
        }

        public static void MyReverse(int []array)
        {
            var reverseArray = new int[array.Length];
            for (int i = array.Length-1; i >= 0; i--)
            { 
                reverseArray[array.Length-(i+1)] = array[i];
            }

            foreach (var item in reverseArray)
            {
                Console.Write($"{item} ");
            }
        }
        public static void SubArray(int[] array, int index, int count)
        {
            var subArray = new int[count];
            for (int i = index, k=0; k < count && i < array.Length; i++, k++)
            {
                    subArray[k] = array[i];
            }

            for (int k = 0; k < count; k++)
            {
                if (k >= (array.Length - index))
                {
                    subArray[k] = 1;
                }
            }

            foreach (var item in subArray)
            {
                Console.Write($"{item} ");
            }
        }

        public static void IncreaseLength(int[] array, int value)
        {
            var newArray = new int[array.Length+1];
            newArray[0] = value;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i-1];
            }

            foreach (var item in newArray)
            {
                Console.Write($"{item} ");
            }

        }

        public static void FoundInArray(int[] array, int x)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"{x} occurs in the array {count} times");
            }
            else
            {
                Console.WriteLine($"{x} not found");
            }
        }
    }
}