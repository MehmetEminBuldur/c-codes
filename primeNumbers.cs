using System;

namespace primeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("please enter bound number");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 2; i < n; i++)
            {
                arr[i] = 1;
            }
            for(int i = 2; i < n; i++)
            {
                if (arr[i] == 1)
                {
                    for(int j = i; i * j < n; j++)
                    {
                        arr[i * j] = 0;
                    }
                }
            }
            for(int i = 2; i < n; i++)
            {
                if (arr[i] == 1)
                {
                    Console.WriteLine(i);      
                }
            }
            Console.ReadLine();
        }
    }
}
