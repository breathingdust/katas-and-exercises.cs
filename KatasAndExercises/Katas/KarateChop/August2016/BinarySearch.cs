namespace KatasAndExercises.Katas.KarateChop.August2016
{
    /// <summary>
    /// Time: O(log n)
    /// Set start index to beginning of array
    /// Set end to last index of array (length -1)
    /// Set initial midpoint using the indexes, for an odd numbered array it will be the middle
    /// for an even numbered array it will be the smaller of the two middle values.
    /// loop
    /// if the midpoint element is the target then return
    /// if the midpoint is bigger than the target, then make endIndex equal to the midpoint -1
    /// else if the midpoint is smaller than the target, then make the start index equal to the midpoint + 1
    /// Recalculate the midpoing
    /// </summary>
    class BinarySearch : IBinarySearch
    {
        public int Search(int target, int[] sortedArray)
        {
            if (sortedArray.Length == 0) return -1;

            var startIndex = 0;
            var endIndex = sortedArray.Length - 1;
            var midpoint = (startIndex + endIndex + 1) / 2;

            do
            {
                if (sortedArray[midpoint] == target)
                    return midpoint;

                if (sortedArray[midpoint] > target)
                {
                    endIndex = midpoint - 1;
                }
                else
                {
                    startIndex = midpoint + 1;
                }
                midpoint = (startIndex + endIndex + 1) / 2;
            } while (startIndex <= endIndex);
            return -1;
        }
    }
}