using DSA._1_Basics;
using DSA._2_DataStructure_Basics._3_Arrays.One_D_Array;
using DSA.Stiverr_PlayList._3_Arrays;
using DSA.Stiverr_PlayList._3_Arrays._1_Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1_Basics 
            #region  _1_FirstProgram/StaticKeyWord

            #endregion



            #endregion

            #region 2_DataStructure_Basics

            #region 3_Arrays

            //_1_ArrayBasics.ArrayDefaultValues();
            // Define test cases
            //int[][] testCases = new int[][]
            //{
            //    new int[] { 20, 412, 3, 123, 42, 12 }, // Normal case
            //    new int[] { 1, 2, 3, 4 },             // Even-length array
            //    new int[] { 5, 6, 7, 8, 9 },          // Odd-length array
            //    new int[] { 10 },                     // Single element array
            //    new int[] { 2 },                        // Empty array
            //    new int[] { -1, -2, -3, -4 },         // Negative numbers
            //    new int[] { 0, -1, 2, -3, 4 },        // Mixed numbers
            //    new int[] { 1, 2, 2, 3 },             // Duplicates
            //    new int[] { 7, 7, 7, 7 },             // Identical elements
            //    new int[] { 1, 2, 3, 1000 },          // Large array
            //    new int[] {int.MaxValue, int.MinValue, 0, -123456789, 987654321, 42, 0, -42, int.MaxValue, int.MinValue }
            //};
            //int[][] testCases1 = new int[][]
            //{

            //    new int[] { 5, 6, 7, 8, 9 },          // Odd-length array
            //    new int[] { 10 },                     // Single element array

            //};
            //// Loop through each test case and call the Solution method
            //foreach (var testCase in testCases)
            //{
            //    //Console.WriteLine("Original Array: " + string.Join(", ", testCase));
            //    _2_ArrayProblems.Solution(testCase);

            //    //Console.WriteLine("Reversed Array: " + string.Join(", ", testCase));
            //    Console.WriteLine("-------------------------");
            //}

            #endregion




            #endregion

            int[] arr = { 1, 2, 0, 3, 4,0,5 };
            //int[] arr2 =  { 8,0,-0,7,9};
            int[] arr2 = { 0, 2, 0, 0, 7, 0, 0, 10,10,0,17 };
            ////_1_LargestElementInArray.ArrayMAx();

            Console.WriteLine("BruteForceSolution");
            PracticeMoveZerosToEnd.TwoPointersolution(arr);
            Console.WriteLine();
            PracticeMoveZerosToEnd.TwoPointersolution(arr2);

            //Console.WriteLine("///////////////////////////////////");

            //Console.WriteLine("OptimalSolution");
            //_6_LeftOrRightRotateByDnum.optimalSolution(arr);
            //Console.WriteLine();
            //_6_LeftOrRightRotateByDnum.optimalSolution(arr2);
        }
        
    }
}
