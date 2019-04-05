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
            ////Задание 1

            //int xl;
            //xl = 2;
            //Console.WriteLine(xl);

            ////Задание 2

            //string str1;
            //Console.WriteLine("Ваше имя?");
            //str1 = Console.ReadLine();
            //string str2="Привет " + str1;
            //Console.WriteLine(str2);

            ////Задание 3

            //var v1 = 'v';
            //v1 = 'r';
            //Console.WriteLine(v1);

            ////Задание 4

            //Console.WriteLine("Введите длину стороны квадрата");
            //string s = Console.ReadLine();
            //int x = Convert.ToInt32(s);
            //int p = 4 * x;
            //Console.WriteLine($"Периметр квадрата {p}");

            ////Задание 5

            //double r1 = 8;
            //double r2 = 6;
            //double s1, s2,s3;
            //const double pi = 3.14;
            //s1 = pi * r1 * r1;
            //s2 = pi * r2 * r2;
            //s3 = s1 - s2;
            //Console.WriteLine($"Площадь первого круга равна {s1}, площадь второго круга равна {s2}, площадь кольца равна {s3}");

            ////Задание 6

            //Console.WriteLine("Введите двузначное число");
            //string strx = Console.ReadLine();
            //int x = Convert.ToInt32(strx);
            //int a, b;
            //b = x / 10;
            //a = x % 10;
            //Console.WriteLine($"Левая сторона {b}");
            //Console.WriteLine($"Правая сторона {a}");

            ////Задание 7
            //int a = 123;
            //int b = 987;
            //long c = a + b;
            //Console.WriteLine(c);

            ////Задание 8
            //long a = 23423;
            //long b = 12312414124;
            //byte c = (byte)(a + b);
            //Console.WriteLine(c);

            //Задание 9
            int x1 = 3;
            int x2 = 4;
            Console.WriteLine($"X1={x1}, X2={x2}");

            //Способ 1
            x1 = x1 + x2;
            x2 = x1 - x2;
            x1 = x1 - x2;
            Console.WriteLine($"После смены местами первым способом X1={x1}, X2={x2}");

            //Способ 2
            int y;
            y = x1;
            x1 = x2;
            x2 = y;
            Console.WriteLine($"После смены местами вторым способом  переменные возвращаются в исходный порядок X1={x1}, X2={x2}");

        }
    }
}
