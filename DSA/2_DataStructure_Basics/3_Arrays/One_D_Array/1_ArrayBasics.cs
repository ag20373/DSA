using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._2_DataStructure_Basics._3_Arrays.One_D_Array
{
    static class _1_ArrayBasics
    {
        public static void CreateArray()
        {
            // Declaring and Initiliing
            int[] arr1 = new int[3];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;

            // Direct Values
            int[] arr2 = new int[] { 10, 29, 390 };

            // Short syntex 
            int[] arr3 = { 10, 20, 39 };
        }

        public static void ArrayDefaultValues()
        {
            int[] arr1 = new int[3];
            bool[] arr2 = new bool[5];
            string[] arr = new string[5];
            
            foreach(var item in arr1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    static class ArrayOperations
    {
        //static int[] arr = new int[] { 10, 20, 30, 40, 50 };
        public static void BasicOperation(int[] arr)
        {
            int firstelement = arr[0]; // First Element / 0-Index Element 
            int lastelement = arr[arr.Length - 1]; // Last Element / Last-Index Element 
            int Size = arr.Length; // Get Length of Array
            
            // Traversing Whole Array
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 10)
                {
                    arr[i] = 20; // Modifying a element
                }
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr); // Sort The Array
            Array.Reverse(arr); // Reverse The Array
            Array.IndexOf(arr, 20); // Find The Index Of the Element.
            Array.Copy(arr, new int[arr.Length], arr.Length); // Create a copy of Exisiting Array
            Array.Exists(arr, num => num == 20); // Checks If Array Element Exist Or Not, Return Bool
            Array.Find(arr, num => num == 20); // Get Us First Occurence Of  20, If Exisit.
            Array.FindIndex(arr, num => num > 20); //Return the First Index ,where Num  > 20
            Array.Clear(arr, 1, 8); // Reset To Zero For Index 1 to 9,
            int[] arr1 = (int[])arr.Clone(); // Clone the Arr to Arr1.
            string.Join(",", arr); // Convest The Array To String as Output.
            Array.Resize(ref arr, 15); // Resize the Exisitng Array to 15.
            int Sum = arr.Sum(); // Return Sum Of All the Elements.
            int Max = arr.Max(); // Return Max Element in array.
            int Min = arr.Min(); // Return the Min Element in Array.
        }
    }
}
