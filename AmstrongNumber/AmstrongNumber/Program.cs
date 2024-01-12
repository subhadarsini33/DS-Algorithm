using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp,b,sum=0;

                Console.WriteLine("Enter Amstrong Numer");
                int d = int.Parse(Console.ReadLine());
                temp = d;
            while(d>0){
                b = d % 10;
                sum = sum +( b * b * b);
                d = d / 10;

            }

            if (temp == sum)
            {
                Console.WriteLine("It Is amstrong number");
            }
            else  {

                Console.WriteLine("It Is  not a amstrong number");
            }

            Console.ReadLine();
       
      }  
        
  }  

  }
  