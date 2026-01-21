using System;
using System.Collections.Generic;
using System.Linq;
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


        }
    }
}
