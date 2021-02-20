using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public class MergeSorter
    {
        List<int> list = new List<int>();
        public List<int> merge_sort(List<int> numbers) 
        {
            if (numbers.Count <= 1)
                return numbers;

            //Recursive case. Divide list into equal-sized sublists consisting of the even + odd indexed elements. 
            var left = new List<int>();
            var right = new List<int>();
            for (var i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    right.Add(numbers[i]);
                }
                else
                {
                    left.Add(numbers[i]);
                }
            }
            left = merge_sort(left);
            right = merge_sort(right);

            return merge(left, right);
        }


        //merges the left and right sublists. 
        public List<int> merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count != 0 && right.Count != 0)
            {
                if (left.First() <= right.First()) 
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);

                }
            }

            //add in remaining elements.
            while (left.Count != 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }

            while (right.Count != 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }
            return result; 
        }
    }
}