using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _3_CheckArrayIsSorted
    {
        // Time Complexity : O(N^N) , Space Complexity : O(1)
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            bool val = false;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Console.WriteLine("False");
                        val = true;
                        break;
                    }
                }
            }
            if(!val)
            Console.WriteLine("True");

        }

        // Time Complexity : O(N) ,Space Complexity : O(1)
        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            bool val = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Console.WriteLine("False");
                    val = true;
                    break;
                }
            }
            if (!val)
                Console.WriteLine("True");
        }
    }
}
