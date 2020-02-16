using System;

namespace insertionSortt
{
    class insertionSort
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter a number(length of array):");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter " + (i + 1) + ". elemet of array:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + "-)  " + arr[i]);
            }
            Console.ReadLine();
        }
    }
}
