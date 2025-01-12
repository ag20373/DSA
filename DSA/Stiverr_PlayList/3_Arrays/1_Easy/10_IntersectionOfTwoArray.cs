using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _10_IntersectionOfTwoArray
    {
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            int[] arr1 = new int[] { 1,1,1,3,4,7 };
            Console.WriteLine("Array 1");
            CommonClass.PrintArray(arr1);
            int[] arr2 = new int[] { 1,1,5,6,7 };
            int[] Visited = new int[arr2.Length>=arr1.Length ? arr2.Length:arr1.Length];
            Console.WriteLine("Array 2");
            CommonClass.PrintArray(arr2);

            List<int> hr = new List<int>();
            for(int j = 0;j<arr1.Length;j++)
            {
                for(int i = 0; i < arr2.Length; i++)
                {
                    if(arr2[i] > arr1[j])
                    {
                        break;
                    }
                    if (arr2[i] == arr1[j] && Visited[i]!=1)
                    {
                        hr.Add(arr1[j]);
                        Visited[j] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine("Array Intersection");
            CommonClass.PrintArray(hr.ToArray());
        }

        public static void optimalSolution(int[] vector)
        {
            CommonClass.Print(false);
            int[] arr1 = new int[] { 1,1, 2, 3, 4, 8, 9, 21, 32 };
            Console.WriteLine("Array 1");
            CommonClass.PrintArray(arr1);

            int[] arr2 = new int[] { 1,1,1,2, 3, 4, 8 };
            Console.WriteLine("Array 2");
            CommonClass.PrintArray(arr2);

            int[] Union = new int[arr1.Length + arr2.Length];
            int Length1 = arr1.Length;
            int Length2 = arr2.Length;
            int i = 0, j = 0, p = 0;
            while(i<Length1 && j < Length2)
            {
                if(arr1[i] == arr2[j])
                {
                    Union[p] = arr1[i];
                    i++; p++; j++;
                }
                else
                {
                    if (arr2[i] < arr2[j])
                    {
                        i++;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            Console.WriteLine("Array Intersection");
            CommonClass.PrintArray(Union);
        }
    }
}
