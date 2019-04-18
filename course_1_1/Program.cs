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
            //String2();

            //String3();

            //String4();

            //String5();

            //String6();

            String7();


        }

        public static void String2()
        {
            Console.WriteLine("Add text line");
            string text = Console.ReadLine();
            Console.WriteLine("Add symbol");
            char symbol = Convert.ToChar(Console.Read());
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==symbol)
                {
                    counter++;
                }
            }
            Console.WriteLine($"{counter}");
        }

        public static void String3()
        {
            Console.WriteLine("Add text line");
            string text = Console.ReadLine();
            Console.WriteLine("Add text line 2");
            string text2 = Console.ReadLine();
            Console.WriteLine("Enter position");
            int position=Convert.ToInt32(Console.ReadLine());
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i == position)
                {
                    result += text2;
                }
                result += text[i];
            }
            
            Console.WriteLine(result);
        }

        public static void String4()
        {
            Console.WriteLine("Add text line");
            string text = Console.ReadLine();
            char question = '?';
            string result = "";
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == question)
                {
                    counter++;
                }
                else if (counter == 1)
                {
                   if (text[i] == ' ')
                   {
                      continue;
                   }
                }
                result += text[i];
            }

            Console.WriteLine(result);
        }

        public static void String5()
        {
            Console.WriteLine("Add text line");
            string text = Console.ReadLine();
            var strArray = text.Split(' ');
            string result = "";

            for (int i = 0; i < strArray.Length; i++)
            {
                if(strArray[i]!=string.Empty)
                { 
                result += strArray[i]+ " ";
                }
            }
            result = result.Trim();

            Console.WriteLine(result);
        }

        public static void String6()
        {
            Console.WriteLine("Add text line");
            string text = Console.ReadLine();
            Console.WriteLine("Enter position");
            int position = Convert.ToInt32(Console.ReadLine());
            var strArray = text.Split(' ');
            string word = "";

            for (int i = 0; i < strArray.Length; i++)
            {
                word = strArray[position-1];
            }

            Console.WriteLine(word[0]);
        }

        public static void String7()
        {
            Console.WriteLine("Add text line");
            string text = Console.ReadLine();
            var strArray = text.Split(' ');
            string result = "";

            for (int i = strArray.Length-1; i>= 0; i--)
            {
                result += strArray[i] + " ";
            }
            result = result.Trim();

            Console.WriteLine(result);
        }
    }
}
