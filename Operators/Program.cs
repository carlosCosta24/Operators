using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            int result;
            bool Flag = true;

            result = +num;
            Console.WriteLine("+Number = " + result);

            result = -num;
            Console.WriteLine("-Number = " + result);

            result = ++num;
            Console.WriteLine("++Number = " + result);

            result = --num;
            Console.WriteLine("--Number = " + result);

           
            Console.WriteLine("!Flag = " + (!Flag));

            Console.WriteLine((num++));
            Console.WriteLine((num));

            Console.WriteLine((++num));
            Console.WriteLine((num));

            Console.WriteLine("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            //Ternary Operator
            bool IsOlder = Age >= 27 ? true : false;
            if (IsOlder) {

                Console.WriteLine("You are older than me :-)");
            }
            else
            {

                Console.WriteLine("I am older than you :-(");
            }


        }
    }
}
