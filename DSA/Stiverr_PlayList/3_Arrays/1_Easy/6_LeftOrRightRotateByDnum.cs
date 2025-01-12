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
            // We have Removed all the Elements that need to be at the end off array
            // Now taking each element left one by one to top of array.
            for(int i = ActualRotation; i < arr.Length; i++)
            {
                arr[i - ActualRotation] = arr[i];
            }

            // Re-Storing TempData back to Original
            // Storing all those that need to be go in End now.
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

    public static class RightRotateByDnum
    {
        // 1,2,4,5,7,9,9,10
        // 9,9,10,1,2,4,5,7
        public static void GoodApproach(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            // Get The Actual No Of Rotation
            int Rotation = 1035;
            int ActualNoOfRotation = Rotation % arr.Length; //X
            Console.WriteLine($"Number Of Rotations Req : {ActualNoOfRotation}");

            //Store All The Elements From the Right Till Rotation to a List.
            List<int> TempData = new List<int>();
            int LoopStart = arr.Length - ActualNoOfRotation;
            for (int i = LoopStart; i < arr.Length; i++) //O(ActualNoOfRotation)
            {
                TempData.Add(arr[i]);
            }

            // Right Rotate the Elements by (i+ActtualnumberOfRotations)
            for (int i = (LoopStart) - 1; i >= 0; i--) //O(arr.Length - ActualNoOfRotation)
            {
                arr[i + ActualNoOfRotation] = arr[i];
            }

            int j = 0;
            // Restore The Rest elements form list.
            foreach (var item in TempData) //O(ActualNoOfRotation)
            {
                arr[j++] = item;
            }

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);
        }

        // Calculating the number of rotations:𝑂(1)
        // Storing elements in TempData: O(ActualNoOfRotation).
        // Right rotating elements: O(arr.Length−ActualNoOfRotation).
        // Restoring elements: O(ActualNoOfRotation).

        // Total : O(arr.Length)

        public static void OptimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            // Get The Actual No Of Rotation
            int Rotation = 1035;
            int ActualNoOfRotation = Rotation % arr.Length; //X
            Console.WriteLine($"Number Of Rotations Req : {ActualNoOfRotation}");
            // 1,2,4,5,7,9,9,10
            // 9,9,10,1,2,4,5,7q
            ReverseArray(arr,0,(arr.Length-ActualNoOfRotation)-1);
            ReverseArray(arr, arr.Length - ActualNoOfRotation,arr.Length-1);
            ReverseArray(arr, 0, arr.Length-1); // O(N) Times

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);

        }

        private static void ReverseArray(int[] arr, int Low, int High)
        {
            while (Low <= High)
            {
                int Temp = arr[Low];
                arr[Low] = arr[High];
                arr[High] = Temp;

                Low++;
                High--;

            }   
        }
    }
}
