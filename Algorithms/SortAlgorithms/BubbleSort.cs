namespace Algorithms.SortAlgorithms
{
    public class BubbleSort
    {
        public void SortFromEnd(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }

        public void SortFromStart(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var swapped = false;
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] <= arr[j + 1])
                    {
                        continue;
                    }
                    Swap(ref arr[j], ref arr[j + 1]);
                    swapped = true;
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}
