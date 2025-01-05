using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problem.Arrays_Problems.Easy
{
    class LeetCode_1_TwoSum
    {
        public static void BruteForceSolution()
        {
            int[] arr = { 2, 7, 11, 15 };
            int Target = 9;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i]+arr[j] == Target)
                    {
                        Console.WriteLine($"[{i}, {j}]");
                    }
                }
            }
        }

        public static void OptimalSolution()
        {
            int[] arr = { 2, 7, 11, 15 };
            int Target = 9;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            List<int> arr1 = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                int num = Target - arr[i];
                if (keyValuePairs.ContainsKey(num))
                {
                    arr1.Add(i);
                }
                else
                {
                    keyValuePairs[arr[i]] = i;
                }
            }
            foreach(var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
