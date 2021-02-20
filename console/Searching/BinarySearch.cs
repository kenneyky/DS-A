using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.Searching
{
    public class BinarySearch
    {

        public Boolean Iterative(int[] A, int x)
        {
            int left = 0;
            int right = A.Length - 1;
            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (A[mid] == x)
                {
                    return true;
                }
                else if (x < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }

        public Boolean Recursive(int[] A, int x, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            int mid = left + ((right - left) / 2);
            if (A[mid] == x)
            {
                return true;
            }
            else if (x < A[mid])
            {
                return Recursive(A, x, left, mid - 1);
            }
            else
            {
                return Recursive(A, x, mid + 1, right);
            }
        }
    }
}
