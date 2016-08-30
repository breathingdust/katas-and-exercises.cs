namespace mybrainhurts.Katas.KarateChop.August2016
{
    public class RecursiveBinarySearch : IBinarySearch
    {
        public int Search(int target, int[] sortedArray)
        {
            if (sortedArray.Length == 0) return -1;

            return RecursiveSearch(target, sortedArray, 0, sortedArray.Length-1);
        }

        private int RecursiveSearch(int target, int[] sortedArray, int startIndex, int endIndex)
        {
            if (startIndex > endIndex) return -1;

            int midpoint = (startIndex + endIndex)/2;

            if (sortedArray[midpoint] == target) return midpoint;

            if (sortedArray[midpoint] > target)
                return RecursiveSearch(target, sortedArray, startIndex, midpoint - 1);

            return RecursiveSearch(target, sortedArray, midpoint+1, endIndex);
        }
    }
}