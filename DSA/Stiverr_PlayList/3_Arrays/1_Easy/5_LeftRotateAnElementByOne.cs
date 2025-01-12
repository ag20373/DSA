using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _5_LeftRotateAnElementByOne
    { 
        public static void BruteForceSolution(int[] arr)
        {
           
        }

        //1,2,3,4,5  ==> 2,3,4,5,1
        // O(N) Time ,O(1) For Space
        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Temp = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }

            arr[arr.Length - 1] = Temp;

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);
        }
    }
    //1,2,3,4,5  ==> 5,1,2,3,4
    class _5_RightRotateAnElementByOne
    {
        public static void optimalSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Temp = arr[arr.Length-1];

            for(int i = arr.Length-2; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = Temp;

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);
        }
    }
}
