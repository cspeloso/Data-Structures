using Data_Structures.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 5, 6, 9, 3, 4, 1, 0 };
            nums = quickSort.SortArray(nums);
        }
    }
}
