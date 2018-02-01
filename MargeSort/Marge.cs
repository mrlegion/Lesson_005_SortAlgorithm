using System;

namespace MargeSort
{
    public class Marge
    {
        #region PRIVATE

        private void Marges(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;

            int remaining = left.Length + right.Length;

            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else
                {
                    items[targetIndex] = right[rightIndex++];
                }

                remaining--;
                targetIndex++;
            }
        }

        #endregion

        #region PUBLIC

        public void Sort(int[] items)
        {
            // Check length array
            if (items.Length <= 1)
                return;

            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;

            var left = new int[leftSize];
            var right = new int[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            Sort(left);
            Sort(right);

            Marges(items, left, right);
        }

        #endregion

    }
}
