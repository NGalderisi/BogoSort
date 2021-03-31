using System;
using System.Collections.Generic;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 4, 3, 2, 1 };
            Console.WriteLine(numbers);
            int [] final = BogoSort(numbers);
            for (int i = 0; i < final.Length; i++)
                Console.Write($"{final[i]} ");

        }

        static int[] BogoSort (int [] numbers)
        {
            Random rnd = new Random();
            bool unsorted = true;
            int counter = 1;
            int[] checkOrder = new int[numbers.Length];

            while (unsorted)
            {
                checkOrder = new int[numbers.Length];
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
                if (checkOrder[0] < checkOrder[1] && checkOrder[1] < checkOrder[2] && checkOrder[2] < checkOrder[3] && checkOrder[3] < checkOrder[4])
                {
                    unsorted = false;
                    Console.WriteLine($"It took {counter} attempt(s) to sort this correctly");
                }
                else
                { 
                    counter++;
                }

            }

            return checkOrder;

        }
    }
}
