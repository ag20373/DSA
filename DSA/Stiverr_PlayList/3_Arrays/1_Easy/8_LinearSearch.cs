using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _8_LinearSearch
    {
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Find = 5;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Find)
                {
                    Console.WriteLine($"Element : {Find} Present At Index : {i} ");
                    break;
                }
            }
        }

        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Find = 10;
            if(Array.Exists(arr, x => x == Find))
            {
                Console.WriteLine($"Element : {Find}");
            }
        }
    }
}
