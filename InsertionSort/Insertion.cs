using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Insertion
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

        private int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Index is not found!");
        }

        public void InsertionSort(int[] items)
        {
            int index = 1;

            while (index < items.Length)
            {
                if (items[index].CompareTo(items[index - 1]) < 0)
                {
                    var insertIndex = FindInsertionIndex(items, items[index]);
                    Insert(items, index, insertIndex);
                }

                index++;
            }
        }

        private void Insert(int[] items, int fromIndex, int toIndex)
        {
            // 0 1 2 4 5 6 3 7

            // Save base value to temp variable
            var temp = items[toIndex];
            items[toIndex] = items[fromIndex];    // 0 1 2 3 5 6 3 7

            for (int current = fromIndex; current > toIndex; current--)
            {
                items[current] = items[current - 1];   // 0 1 2 3 5 5 6 7
            }

            items[toIndex + 1] = temp;  // 0 1 2 3 4 5 6 7
        }
    }
}
