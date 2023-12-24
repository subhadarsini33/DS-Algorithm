// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class selectionshort { 
public static  void Main(string[]args)
{
        int i, j;
        int[] arry = { 8, 4, 3, 10, 65, 20 };
        int n = arry.Length;
        for (i=0;i<n-1;i++) {
            int min_value = i;
            for (j=i+1;j<n;j++)
            {
                if ( arry[j] < arry[min_value])
                {
                    min_value = j;

                }
               

            }

            int temp = arry[min_value];
            arry[min_value] = arry[i];
            arry[i] = temp;



        }

        for (i = 0; i < n; ++i)
        {
            Console.Write(arry[i] + " ");

        }
        Console.WriteLine();
        Console.ReadLine();


    }

}

