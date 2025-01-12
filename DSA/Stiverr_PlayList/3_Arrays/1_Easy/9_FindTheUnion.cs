using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _9_FindTheUnion
    {
        // O(n + m) - Time Complexity , // O(n + m) - Space Complexity 
        public static void BruteForceSolution()
        {
            CommonClass.Print(false);
            int[] arr1 = new int[] { 10, 4, 2, 3, 1, 54, 2 };
            Console.WriteLine("Array 1");
            CommonClass.PrintArray(arr1);
            int[] arr2 = new int[] { 10, 6, 7, 3, 8, 23, 2 };
            Console.WriteLine("Array 2");
            CommonClass.PrintArray(arr2);

            SortedSet<int> HS = new SortedSet<int>();

            //Logic 
            foreach(var item in arr1)
            {
                HS.Add(item);
            }

            foreach (var item in arr2)
            {
                HS.Add(item);
            }

            Console.WriteLine("Array Union");
            CommonClass.PrintArray(HS.ToArray());

        }

        public static void optimalSolution()
        {
            CommonClass.Print(false);
            int[] arr1 = new int[] { 1, 2, 3, 4 ,8,9,21,32};
            Console.WriteLine("Array 1");
            CommonClass.PrintArray(arr1);

            int[] arr2 = new int[] { 2, 3, 4, 8 };
            Console.WriteLine("Array 2");
            CommonClass.PrintArray(arr2);

            int[] Union= new int[arr1.Length + arr2.Length];

            int Length1 = arr1.Length;
            int Length2 = arr2.Length;
            int i = 0, j = 0,p=0;

            while (i < Length1 && j < Length2)
            {
                if(arr1[i] <= arr2[j])
                {
                    if (p == 0 || Union[p-1] != arr1[i])
                    {
                        Union[p] = arr1[i];
                        p++;
                    }
                    
                    i++;
                }
                else
                {
                    if (p == 0 || Union[p - 1] != arr2[j])
                    {
                        Union[p] = arr2[j];
                        p++;
                    }

                    j++;
                }
            }

            while (i < Length1)
            {
                if (p == 0 || Union[p - 1] != arr1[i])
                {
                    Union[p] = arr1[i];
                    p++;
                }

                i++;
            }
            while (j < Length2)
            {
                if (p == 0 || Union[p - 1] != arr2[j])
                {
                    Union[p] = arr2[j];
                    p++;
                }

                j++;
            }
            Console.WriteLine("Array Union");
            CommonClass.PrintArray(Union);

        }
    }
}
