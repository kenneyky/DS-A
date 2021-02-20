using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSorter
    {
        public void quickSort(int[] a)
        {
            quickSort(a, 0, a.Length - 1);
        }

        private void quickSort(int[] a, int low, int high)
        {
            if (low < high + 1)
            {
                int p = partition(a, low, high);
                quickSort(a, low, p - 1); //left partition
                quickSort(a, p + 1, high); //right partition
            }
        }

        private void swap(int[] A, int index1, int index2)
        {
            int temp = A[index1];
            A[index1] = A[index2];
            A[index2] = temp;
        }

        //returns random pivot index between low and high inclusive
        private int getPivot(int low, int high)
        {
            Random rand = new Random();
            return rand.Next((high - low) + 1) + low;
        }

        //moves all n < pivot to left of pivot and all n > pivot
        //to right of pivot, then returns pivot index.
        private int partition(int[] A, int low, int high)
        {
            swap(A, low, getPivot(low, high));
            int border = low + 1;
            for (int i = border; i <= high; i++)
            {
                if (A[i] < A[low])
                {
                    swap(A, i, border++);
                }
            }
            swap(A, low, border - 1);
            return border - 1;
        }

    }
}
