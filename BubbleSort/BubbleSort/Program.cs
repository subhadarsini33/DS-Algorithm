// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class BubbleSort
{
    public static void Main(string[] args)
    {
        int[] arry = { 5, 1, 4,6,9,32,10,22,18 };
        int n = arry.Length;
        int i, j;
        for (i=0;i<n-1;i++)
        {
            for (j=0;j<n-i-1;j++)
            {
                if (arry[j] > arry[j+1])
                {
                    int temp = arry[j];
                    arry[j] = arry[j + 1];
                    arry[j + 1] = temp;


                }

            }

        }
        for (i=0;i<n;i++)
        {
            Console.Write(arry[i] + " ");
            
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
