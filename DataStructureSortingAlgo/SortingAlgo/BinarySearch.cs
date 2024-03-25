using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSortingAlgo.SortingAlgo
{
    public class BinarySearch
    {
        public static void FindNo(int[]arr,int key)
        {
            int start = 0;
            int end = arr.Length;
            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                if (arr[middle] == key)
                {
                    Console.WriteLine("Found");
                    return;
                }
                else if (key < arr[middle])
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

        }
    }
}
