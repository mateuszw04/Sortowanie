using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class QuickSort
    {

        public void Sort(int[] tab, int l, int r)
        {
            if (l < r)
            {
                int pivot = partycja(tab, l, r);
                Sort(tab, l, pivot - 1);
                Sort(tab, pivot + 1, r);
            }
        }

        private static int partycja(int[] tab, int l, int r)
        {
            int pivot = tab[r];
            int i = l - 1;

            for (int j = l; j < r; j++)
            {
                if (tab[j] <= pivot)
                {
                    i++;
                    swap(tab, i, j);
                }
            }

            swap(tab, i + 1, r);
            return i + 1;
        }

        private static void swap(int[] tab, int i, int j)
        {
            int temp = tab[i];
            tab[i] = tab[j];
            tab[j] = temp;
        }

    }
}
