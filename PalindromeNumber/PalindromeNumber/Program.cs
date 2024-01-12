using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum=0,temp;
            Console.WriteLine("Enter a number!");
            int readn = int.Parse(Console.ReadLine());
            temp = readn;
            while (readn>0)
            {
                a = readn % 10;
                sum = (sum * 10) + a;
                readn = readn / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("It is palendorium number");
            }
            else
            {
                Console.WriteLine("It is not a palendorium number");
            }
            Console.ReadLine();

        }
    }
}
