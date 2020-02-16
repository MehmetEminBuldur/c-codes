using System;

namespace binarySearchh
{
    class binarySearch
    {
        static void Main(string[] args)
        {
            int n, mid,low = 0;
            Console.WriteLine("Please enter the length of array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int high = n - 1;
            mid = (low + high) / 2;
            for(int i = 0; i < n; i++)
            {
                Random num = new Random();
                arr[i] = num.Next(1, 100);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Please enter a number for search:");
            int x = Convert.ToInt32(Console.ReadLine());
            while (low < high && arr[mid] != x)
            {
                if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                mid = (high + low) / 2;
            }
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }
            if (arr[mid] != x)
            {
                Console.WriteLine("There is not such an element in the array!");
            }
            else
            {
                Console.WriteLine("Index of searched element:" + mid);
            }
            Console.ReadLine();
        }
    }
}
