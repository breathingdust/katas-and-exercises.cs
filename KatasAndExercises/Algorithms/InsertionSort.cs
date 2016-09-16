using System;

namespace KatasAndExercises.Algorithms
{
    public class InsertionSort: ISorter
    {
        public int[] Sort(int[] unsortedArray)
        {
            for (int i = 1; i < unsortedArray.Length; i++)
            {
                var insertionValue = unsortedArray[i];
                var position = i;

                while (position > 0 && unsortedArray[position-1] > insertionValue)
                {
                    unsortedArray[position] = unsortedArray[position - 1];
                    position--;
                }

               unsortedArray[position] = insertionValue; 
            }
            return unsortedArray;
        }
    }
}