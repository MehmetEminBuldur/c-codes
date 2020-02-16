using System;

namespace selectionSortt
{
    class selectionSort
    {
        static void Main(string[] args)
        {
            int n,min=0,temp;
            Console.WriteLine("please enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("please enter " + (i+1) + ". element of array:");               
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(" " + arr[i] + " ");
            }
        }
    }
}
