using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ArraySorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 5, 4, 3, 2, 1 };
            BogoSort(numbers);

        }

        public static int[] BogoSort (int [] numbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
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
                for (int i = 0; i < numbers.Length-1;)
                {
                    if (checkOrder[i] < checkOrder[i+1])
                    {
                        if (i == (numbers.Length - 2))
                        {
                            stopWatch.Stop();
                            TimeSpan ts = stopWatch.Elapsed;
                            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                            unsorted = false;
                            Console.WriteLine("RunTime " + elapsedTime);
                            Console.WriteLine($"It took {counter} attempt(s) to sort this correctly");
                            for (int x = 0; x < checkOrder.Length; x++)
                                Console.Write($"{checkOrder[x]} ");

                        }
                        i++;
                    }
                    else
                    {
                        counter++;
                        break;
                    }
                }
            }
            return checkOrder;

        }
    }
}
