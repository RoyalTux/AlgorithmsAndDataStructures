namespace Algorithms.SearchAlgorithms
{
    public class LinearSearch
    {
        public int Search(int[] array, int data)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (data == array[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
