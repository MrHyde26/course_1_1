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
            ArrayUnpacking();
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
            Console.WriteLine();


            for (int i = 0; i < array.Length; i++)
            {
                   for (int j = 0; j < array[i]; j++)
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
    }
}
