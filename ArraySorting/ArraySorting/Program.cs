using System;
using System.Collections.Generic;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };
            Console.WriteLine(numbers);
            int [] final = BogoSort(numbers);
            for (int i = 0; i < final.Length; i++)
                Console.Write($"{final[i]}, ");

        }

        static int[] BogoSort (int [] numbers)
        {
            Random rnd = new Random();
            int[] checkOrder = new int[numbers.Length];
            List<int[]> ordersChecked = new List<int[]>();
            List<int> arrayPlaceChecker = new List<int>();

            for (int i = 0; i < numbers.Length;)
            {
                int arrayPlace = rnd.Next(0, numbers.Length);
                if (!arrayPlaceChecker.Contains(arrayPlace))
                {
                    arrayPlaceChecker.Add(arrayPlace);
                    checkOrder[i] = numbers[arrayPlace];
                    i++;
                }
            }

            return checkOrder;

        }
    }
}
