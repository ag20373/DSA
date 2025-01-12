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

    static public class PracticeArrayIsSortedOrNot
    {
        //Time Complexity : O(N) And Space Complexity : O(1)
        public static void Problem1(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            bool Sorted = true;

            for(int i = 0; i < arr.Length-1; i++)
            {
                if (!(arr[i] <= arr[i + 1]))
                {
                    Sorted = false;
                    break;
                }
            }

            if(Sorted)
            {
                Console.WriteLine($"Array Is Sorted");
            }
            else
            {
                Console.WriteLine($"Array Is Not Sorted");
            }

        }

        //Problem Statement :LeetCode 1752. Check if Array Is Sorted and Rotated
        //Time Complexity : O(n * (2n)) => O(n^2) ,Space Compleixty : O(1)
        public static void BruteForce(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            bool Sorted = true;

            int Item = 0;
            int TotalNoOFRotation = 0;
            bool checkForSort = true;
            //Time Complexity : O(n * (2n)) => O(n^2) ,Space Compleixty : O(1)
            for(int i = 0; i < arr.Length; i++)
            {
                #region Check For Sorting
                checkForSort = true;
                
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (!(arr[j] <= arr[j + 1]))
                    {
                        checkForSort = false;
                        break;
                    }
                }
                if (checkForSort == true)
                {
                    break;
                }
                #endregion

                #region Rotate The Element
                Item = arr[0];
                TotalNoOFRotation += 1;
                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = Item;
                #endregion

            }

            if (checkForSort)
            {
                Console.WriteLine($"Array Is Sorted , No of Rotation Req : {TotalNoOFRotation}");
            }
            else
            {
                Console.WriteLine($"Array Is Not Sorted");
            }

        }

        #region Porblem Discreption
        // Given a Array is Sorted And Rotated only if their one disruption Point between then
        // Example : 34512 -> One disruption Point between 5 and 1 (Sorted)
        //           567127 -> Two disruption Point Between 7 and 1 , 7 and 5 (Not Sorted)
        //           81549  -> Three disruption Point Between 8 and 1, 5 and 4 ,9 and 8
        // In an Array of length 5....
        // 1%5 = 1 ,2%5 = 2 ,3%5 =3 ,4%5 =4, 5%5=0 ,6%5 = 1 ....So On
        // So when we have OverFlow Condition like i%5 where i = 6 ,then 6%5 can be 1.
        // If we cana ble to find only one disruption Point We can say array is sorted.

        // How To Find the Number of Rotation need for Array to original Place
        // Index of disruptionPoint

        // How To know how many Rotations have happend.
        // ArrayLength - Index of disruptionPoint
        #endregion
        //Time Complexity : O(N) ,Space Complexity O(1)
        public static void OptimalSolution(int[] arr)
        {
            int disruptionPoint = 0;
            int RotatedPoint = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (!(arr[i] < arr[(i + 1) % arr.Length]))
                {
                    disruptionPoint++;
                }
            }

            if(disruptionPoint > 1)
            {
               
            }
        }
    }
}
