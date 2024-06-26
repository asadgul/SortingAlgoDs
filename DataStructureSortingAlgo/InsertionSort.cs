﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSortingAlgo
{
    public class InsertionSort
    {
        public static void Sort(int[]arr)
        {
            int j = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                j = i - 1;
                while(j>=0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = temp;
            }
        }
    }
}
