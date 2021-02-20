using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.Sorting
{
    public class LibrarySorting
    {
        //pretty easy, but most interviews won't make you use Merge or Quick sorts. 
        //This is helpful to at least know. 
        public void sortList(List<int> list)
        {
            list.Sort();
        }

        public void sortArray(int[] A)
        {
            Array.Sort(A);
        }
    }
}
