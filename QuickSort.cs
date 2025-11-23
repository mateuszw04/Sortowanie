using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class QuickSort
    {

        public static void sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = partycja(arr, left, right);
                sort(arr, left, pivot - 1);
                sort(arr, pivot + 1, right);
            }
        }

        private static int partycja(int[] arr, int l, int r)
        {
            int pivot = arr[r];
            int i = l - 1;

            for (int j = l; j < r; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }

            swap(arr, i + 1, r);
            return i + 1;
        }

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
