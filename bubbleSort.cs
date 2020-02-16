using System;

namespace bubbleSortt
{
    class bubbleSort
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter a number(length of array):");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter " + (i + 1) + ". element of array:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + "-)  " + arr[i]);
            }
            Console.ReadLine();
        }
    }
}
