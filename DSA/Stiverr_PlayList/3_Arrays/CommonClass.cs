using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stiverr_PlayList._3_Arrays
{
    static class CommonClass
    {
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        public static void Print(bool Val)
        {
            if (Val)
            {
                Console.WriteLine("Array After");
            }
            else
            {
                Console.WriteLine("Array Before");
            }
        }
    }
}
