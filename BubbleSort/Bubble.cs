namespace BubbleSort
{
    public class Bubble
    {
        private void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public void BubbleSort(ref int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 1; j < items.Length - i; j++)
                {
                    if (items[j - 1].CompareTo(items[j]) > 0)
                    {
                        Swap(items, j - 1, j);
                    }
                }
            }

        }
    }
}
