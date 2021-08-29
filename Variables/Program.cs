using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {

        //public enum ShippingMethod{
        //    RegularAirMail = 1,
        //    RegisteredAirMail = 2,
        //    Express = 3
        //}


        static void Main(string[] args)
        {
            //Person john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            //var numbers = new int[3];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "Jack", "John", "Mary" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //String firstName = "Christian";

            //String lastName = "Anderson";

            //String fullName = firstName + " " + lastName;

            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString());

            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //value type

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //what will be the first element in array1? | It will be 0 | reference type
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
