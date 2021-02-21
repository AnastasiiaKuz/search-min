using System;

namespace Min_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]; //объявление массива 
            Console.WriteLine("Enter 10 integers: ");

            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("The " + i + " integer is " + a[i]);
            }
            int res = search_min (a);
            System.Console.WriteLine($"Result is: {res}");
        }

        static int search_min(int[] b)
        {
            int min = b[0];
            for (int i = 1; i < 10; i++)
            {
                if (b[i] < min)
                {
                 min = b[i];
                }
             }
            return min;
        }
    }
}
