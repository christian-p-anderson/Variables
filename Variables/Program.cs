using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    partial class Program
    {

        static void Main(string[] args)
        {
            //for (int i = 10; i >= 1; i--)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //string name = "John Smith";
            //foreach (char character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    string input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo :" + input);
            //        continue;
            //    }

            //    break;

            //}

            //var random = new Random();

            //const int passwordLength = 10;

            //var buffer = new char[passwordLength];

            //for (int i = 0; i < passwordLength; i++)
            //{
            //    buffer[i] = ((char)('a' + random.Next(0, 26)));

            //}
            //var password = new string(buffer);
            //Console.WriteLine(password);

            Exercise();
        }

        public static void Exercise()
        {
            Console.Write("Enter comma seperated numbers:");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Max is " + max);
        }

    }

}
