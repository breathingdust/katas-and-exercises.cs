namespace mybrainhurts.Algorithms
{
    /// <summary>
    /// Time: O(n^2)
    /// However when the list is already sorted the performance is O(n)
    /// Space: O(1)
    /// </summary>
    public class BubbleSort : ISorter
    {
        public int[] Sort(int[] input)
        {
            bool needsAnotherPass;
            do
            {
                needsAnotherPass = false;

                for (int i = 0; i < input.Length-1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i+1] = temp;
                        needsAnotherPass = true;
                    }
                }
            } while (needsAnotherPass);
            return input;
        }
    }
}