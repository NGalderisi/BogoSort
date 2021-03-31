using System;
using System.Collections.Generic;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };
            

        }

        static int[] BogoSort (int [] numbers)
        {
            Random rnd = new Random();
            List<int> arrayPlaceChecker = new List<int>();

            int arrayPlace = rnd.Next(0, numbers.Length);
            if (arrayPlaceChecker.Contains(arrayPlace))
            {
                
                arrayPlaceChecker.Add(arrayPlace);
            }

            int[] placeHolder = { 1, 2 };
            return placeHolder;

        }
    }
}
