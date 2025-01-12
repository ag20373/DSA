using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays._1_Easy
{
    class _7_MoveZerosToEnd
    {
        public static void BruteForceSolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            List<int> TempList = new List<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    TempList.Add(arr[i]);
                }
            }

            int k = 0; 
            foreach(var item in TempList)
            {
                arr[k] = item;
                k++;
            }

            for(int i = k; i < arr.Length; i ++)
            {
                arr[i] = 0;
            }

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);
        }
        
        public static void optimalSolution(int[] arr) 
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);

            int Pointer = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0 && arr[Pointer]!=0)
                {
                    Pointer++;    
                }
                else if(arr[i]!=0&& arr[Pointer]== 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[Pointer];
                    arr[Pointer] = temp;

                    Pointer++;
                }
            }

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);

        }
    }

    static class PracticeMoveZerosToEnd
    {
        public static void TwoPointersolution(int[] arr)
        {
            CommonClass.Print(false);
            CommonClass.PrintArray(arr);
            //1, 2, 0, 3, 4,0,5
            int Pointer = 0; 
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                else
                {
                    int temp = arr[Pointer];
                    arr[Pointer] = arr[i];
                    arr[i] = temp ;
                    Pointer ++;
                }
            }

            CommonClass.Print(true);
            CommonClass.PrintArray(arr);
        }
    }
}
