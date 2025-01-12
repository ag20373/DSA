using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    static class _1_LargestElementInArray
    {
        // Time Complexity : O(NLogN) , Space Complexity : O(1)
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            Array.Sort(arr); // Sorting Will Take O(NlogN)
            //CommonClass.Print(true);
            //CommonClass.PrintArray(arr);

            int Largest = arr[arr.Length - 1];
            int min = arr[0];

            Console.WriteLine($"MAX = {Largest} , MIN = {min}");

        }

        // Time Complexity : O(N) ,Space Complexity : O(1)
        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Largest = int.MinValue;
            int Smallest = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if(Largest < arr[i])
                {
                    Largest = arr[i];
                }
                if(Smallest > arr[i])
                {
                    Smallest = arr[i];
                }
            }
            Console.WriteLine($"MAX = {Largest} , MIN = {Smallest}");
        }     
    }

    //Time Complexity :O(N) ,Space complxity : O(1)
    static public class PracticeLargest_Smallest
    {
        public static void Problem1(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            int Largest = int.MinValue;
            int smallest = int.MaxValue;
            for(int i = 0; i < arr.Length; i++) // O(N) Times
            {
                if(Largest < arr[i])
                {
                    Largest = arr[i];
                }
                if(smallest > arr[i])
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine($"Largest : {Largest} && Smallest : {smallest}");
        }
    } 
}
