using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    static class _2_SecondLargestElement
    {

        // Time Complexity : O(NLogN) , Space Complexity : O(1)
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            Array.Sort(arr); // Sorting Will Take O(NlogN)
            int SecondLargest = arr[arr.Length - 2];
            int SecondSmallest = arr[1];
            Console.WriteLine($"Second Largest = {SecondLargest} , Second Smallest = {SecondSmallest}");

        }

        // Time Complexity : O(N) ,Space Complexity : O(1)
        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Largest = int.MinValue;
            int SecondLargest =int.MinValue ;
            int Smallest = int.MaxValue;
            int SecondSmallest = int.MaxValue;
            int CheckForSame = arr[0];

            for(int i = 0;i < arr.Length; i++)
            {
                if(Largest < arr[i])
                {
                    SecondLargest = Largest;
                    Largest = arr[i];
                }
                else if(SecondLargest < arr[i] && Largest != arr[i])
                {
                    SecondLargest = arr[i];
                }
                if(Smallest > arr[i])
                {
                    SecondLargest = Smallest;
                    Smallest = arr[i];
                }
                else if(SecondSmallest > arr[i] && Smallest != arr[i])
                {
                    SecondSmallest = arr[i];
                }
            }
            // Return -1 ,if Secondlargest is int.MinValue and SecondSmallest is int.MaxValue 
            Console.WriteLine($"Second Largest = {SecondLargest} , Second Smallest = {SecondSmallest}");
        }

        public static void CDProblem(int[] arr)
        {
            int IstL = int.MinValue;
            int SndL = int.MinValue;

            int IntS = int.MaxValue;
            int SndS = int.MaxValue;

            foreach(var item in arr)
            {
                if(IstL < item)
                {
                    SndL = IstL;
                    IstL = item;
                }
                else if(SndL < item && IstL!=item)
                {
                    SndL = item;
                }

                if (IntS > item)
                {
                    SndS = IntS;
                    IntS = item;
                }
                else if (SndS > item && IntS != item)
                {
                    SndS = item;
                }
            }
        }

    }
}
