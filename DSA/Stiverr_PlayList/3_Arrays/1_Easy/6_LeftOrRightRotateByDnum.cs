using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _6_LeftOrRightRotateByDnum
    {
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Rotate = 23;

            // This Array Needs tp be Rotate Atleast 23 time.
            // Consider Array Size is 10 -> then 10 + 10 + 3
            // 10 time rotations Array Comes in Original Place
            // So Rotating Array 20 Times Become Irrevalent ,so max no of rotation we need in 3 only
            int ActualRotation = Rotate % arr.Length;

            // Storing Data Temprary 
            List<int> TempData = new List<int>();
            for(int i = 0; i < ActualRotation ; i++)
            {
                TempData.Add(arr[i]);
            }

            // Left Rotating
            for(int i = ActualRotation; i < arr.Length; i++)
            {
                arr[i - ActualRotation] = arr[i];
            }

            // Re-Storing TempData back to Original
            for(int i = arr.Length-ActualRotation; i < arr.Length; i++)
            {
                arr[i] = TempData[i - (arr.Length - ActualRotation)];
            }

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);
        }

        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Rotate = 23;
            int ActualRotation = Rotate % arr.Length;

            Array.Reverse(arr, 0, ActualRotation); // O(N)
            Array.Reverse(arr, ActualRotation,arr.Length-ActualRotation);
            Array.Reverse(arr, 0, arr.Length);

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);

        }

        // O(N)....
        public static void RotationAlgo(int[] arr ,int start ,int end)
        {
            while (start <= end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
