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

            while (true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo :" + input);
                    continue;
                }

                break;

            }

        }

    }

}
