using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class InsertionSort
    {

        public void Sort(int[] tab)
        {
            int a;
            int poprzedni;
            for (int i = 1; i < tab.Length; i++)
            {
                a = tab[i];
                poprzedni = i - 1;

                while (poprzedni >= 0 && tab[poprzedni] > a)
                {
                    tab[poprzedni + 1] = tab[poprzedni];
                    --poprzedni;
                }
                tab[poprzedni + 1] = a;
            }
        }
    }
}
