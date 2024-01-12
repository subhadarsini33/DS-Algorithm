using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] arry = { 3,7,1,10,9,2,5};
            int n = arry.Length;
            for (i = 1; i < n;i++ )
            {
                int temp = arry[i];
                 j=i-1;
                while(j>=0 && arry[j]>temp )
                {
                    arry[j + 1] = arry[j];
                    j = j - 1;
                }
                arry[j + 1] = temp;
            }

            for (i = 1; i < n; ++i) 
            {
                Console.Write(arry[i]+" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
