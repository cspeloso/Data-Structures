using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.DataStructures
{
    class quickSort
    {
        public static int[] SortArray(int[] nums)
        {
            return QuickSort(nums, 0, nums.Length-1);
        }

        public static int[] QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = partition(arr, low, high);

                arr = QuickSort(arr, low, pi - 1);
                arr = QuickSort(arr, pi + 1, high);
            }

            return arr;
        }

        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for(int j = low; j <= high-1;j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return (i + 1);
        }
    }
}
