using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            /*            string number = "1234";
                        int i = Convert.ToInt32(number);
                        Console.WriteLine(i);


                        try
                        {
                        var num = "1234";
                        byte b = Convert.ToByte(num);
                        Console.WriteLine(b);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("err: the number could not be converted to a byte");
                        }
            */

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a bool");
            }


        }
    }
}
