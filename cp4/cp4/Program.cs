using System;

namespace cp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7, 8, 9,10 };
            task2(arr);
        }
        static void task2(int[] arr)

        {
            int cem = 0;

            for (int i=0;i<arr.Length;i++)
            {
                cem = cem + arr[i];
            }
            double avarage;
            avarage = cem / arr.Length;
            Console.WriteLine(avarage);

        }
    }
}
