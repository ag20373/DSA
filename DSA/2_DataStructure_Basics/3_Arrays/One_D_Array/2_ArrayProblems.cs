using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._2_DataStructure_Basics._3_Arrays.One_D_Array
{
    static class _2_ArrayProblems
    {
        #region Problem 1 : Reverse An Array OF Integer
        private static void ReverseBuildInSolution(int[] arr)
        {
            Console.WriteLine("Array Before");
            PrintArray(arr);

            // Using Inbuild Function
            Array.Reverse(arr);

            Console.WriteLine("Array After");
            PrintArray(arr);
            
        }
        private static void ReverseOptimalLogic(int[] arr)
        {
            Console.WriteLine("Array Before");
            PrintArray(arr);

            // Using Logic
            int First = 0;
            int Last = 0;
            for(int i = 0; i < (arr.Length)/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[(arr.Length - i)-1];
                arr[(arr.Length - i) - 1] = temp;
            }

            Console.WriteLine("Array After");
            PrintArray(arr);

        }

        // Time Complexity O(n) Times.
        // Space Complexity O(1) Times.
        #endregion

        #region Problem 2 : Max And Min In Array
        
        private static void MaxMinInBulidSolution(int[] arr)
        {
            Console.WriteLine("Array");
            PrintArray(arr);

            // Using Inbuild Function
            if (arr.Length != 0)
            {
                int a = arr.Max();
                int b = arr.Min();
                Console.WriteLine($"Max : {a} , Min : {b} ");
            }
            
            
            //PrintArray(arr);
        }
        private static void MaxMinLogic(int[] arr)
        {
            Console.WriteLine("Array");
            PrintArray(arr);

            // Using Inbuild Function
            if (arr.Length != 0)
            {
                int max = arr[0];
                int min = arr[arr.Length-1];

                for(int  i = 0; i < arr.Length; i++)
                {
                    if(max < arr[i])
                    {
                        max = arr[i];
                    }

                    if(min > arr[i])
                    {
                        min = arr[i];
                    }
                }

                Console.WriteLine($"Max : {max} , Min : {min} ");
            }
        }

        // Max() and Min() Return Exception, if There is no Element in the Array
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        #endregion

        #region problem 3 : Find Missing Number in Array

        private static void MissingNumberInbuild(int[] arr)
        {
            Console.WriteLine("Array");
            PrintArray(arr);

            int n = arr.Max();
            for(int i = 0;i <= n; i++)
            {
                if (!Array.Exists(arr, num => num == i))
                {
                    Console.Write(i + ", ");
                }
            }


            //PrintArray(arr);
        }
        
        // Time Complexity : O(max(arr)*n)
        // Time complexity : O(1)
        #endregion



        public static void Solution(int [] arr)
        {
            //ReverseBuildInSolution(arr);
            //ReverseBruteForceLogic(arr);
            //MaxMinInBulidSolution(arr);
            //MissingNumberInbuild(arr);
        }

        private static void PrintArray(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
        }
    }
}
