using System;

namespace linearSearchh
{
    class linearSearch
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the length of array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Random num = new Random();
                arr[i] = num.Next(0, 100);
            }
            int j = 0;
            Console.WriteLine("Please enter a number for search in array:");
            int x = Convert.ToInt32(Console.ReadLine());
            while (j < n && arr[j] != x)
            {
                j++;
            }
            if (j >= n)
            {
                Console.WriteLine("there is not such en elment in the array!");
            }
            else
            {
                Console.WriteLine("Index of searched element: " + j);
            }
        }
    }
}
