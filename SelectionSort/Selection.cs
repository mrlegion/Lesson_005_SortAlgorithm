namespace SelectionSort
{
    public class Selection
    {
        private void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                var temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        private int FindSmallValueIndex(int[] items, int index)
        {
            var currentItem = items[index];
            var currentIndex = index;

            for (int i = currentIndex + 1; i < items.Length; i++)
            {
                if (currentItem.CompareTo(items[i]) > 0)
                {
                    currentIndex = i;
                    currentItem = items[i];
                }
            }

            return currentIndex;
        }

        public void SelectionSort(int[] items)
        {
            int index = 0;

            while (index < items.Length)
            {
                var indexOfSmallValue = FindSmallValueIndex(items, index);
                Swap(items, index, indexOfSmallValue);
                index++;
            }
        }

    }
}
