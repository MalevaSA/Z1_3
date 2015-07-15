using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число в десятичной системе счисления: ");


            string a = Console.ReadLine();
            Console.Write("В двоичной системе счисления: ");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(a, 10), 2));
            Console.Write("В восьмеричной системе счисления: ");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(a, 10), 8));
            Console.Write("В шестнадцатеричной системе счисления: ");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(a, 10), 16));

            Console.ReadKey();
        }
    }
}