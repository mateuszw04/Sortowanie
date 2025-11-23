using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class SelectionSort
    {
        

        public int findSmallest(int[] tab, int indexMarker)
        {
            int smallest = tab[indexMarker];
            int smallestIndex = indexMarker;

            for (int i = indexMarker; i < tab.Length; i++)
            {
                if (tab[i] < smallest)
                {
                    smallest = tab[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public void Sort(int[] tab)
        {


            int markerIndex = 0;
            int minValue = 0;
            int arrLen = tab.Length;
            for (int i = 0; i < arrLen; i++)
            {
                var minValueIndex = findSmallest(tab, markerIndex);


                minValue = tab[minValueIndex];
                tab[minValueIndex] = tab[markerIndex];
                tab[markerIndex] = minValue;
                markerIndex++;
            }

        }
    }
}
