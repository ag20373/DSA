using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._2_DataStructure_Basics._3_Arrays.One_D_Array
{
    class _3_Array_Pass_by_Reference_and_Pass_By_Value
    {
        public static void BruteForceSolution()
        {
            int[] arr = new int[] {23,312,423,123 };
            Console.WriteLine("Original Array");
            PrintArray(arr);
            ModifyArrayValue(arr);
            Console.WriteLine("Array After Modification");
            PrintArray(arr);
            AssigningNewArray(arr);
            Console.WriteLine("Array After Assigning New Array In Method");
            PrintArray(arr);
            AssigningNewArrayUsingRef(ref arr);
            Console.WriteLine("Array After Assigning New Array Using Ref");
            PrintArray(arr);

        }

        private static void AssigningNewArrayUsingRef(ref int[] arr)
        {
            arr = new int[] { 5,4,3,2,1 };
        }

        private static void AssigningNewArray(int[] arr)
        {
            arr = new int[]{ 1, 2, 3, 4 ,5};
        }

        private static void ModifyArrayValue(int[] arr)
        {
            arr[2] = 20;
        }

        public static void PrintArray(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
