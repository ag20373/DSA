using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _4_RemoveDuplicatesFromArray
    {
        // Time Complexity : [O(N)] , Space Complexity : O(N)
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            HashSet<int> Unique = new HashSet<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                Unique.Add(arr[i]);
            }


            CommonClass.Print(true);
            CommonClass.PrintArray(Unique.ToArray());

        }

        // Time Complexity : [O(N*LogN) + O(N)] ,Space Complexity : O(1)
        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            Array.Sort(arr); // O(N*LogN)

            int Pointer = RemoveDuplicate(arr); // O(N)

            for(int item = 0; item < Pointer; item++ )
            {
                Console.Write(arr[item]);
            }
            
        }
        // Time complexity : O(N) and Space Complexity : O(1)
        private static int RemoveDuplicate(int[] arr)
        {
            int Pointer = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    continue;
                }
                else
                {
                    arr[Pointer] = arr[i];
                    Pointer++;
                }
            }

            return Pointer;
        }
    }
}
