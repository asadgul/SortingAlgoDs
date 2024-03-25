using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSortingAlgo.SortingAlgo
{
    public class SelectionSort
    {
        public static void Sort(int[]arr)
        {
            int location = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                location = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[location])
                    {
                        location = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[location];
                arr[location] = temp;
            }
        }
    }
}
