using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            
            Console.WriteLine("One pass Dictionary solution: [{0}]"+ " Target:" + target, string.Join(", ", TwoSum(nums, target)));
            Console.WriteLine("------------------------------");
            Console.WriteLine("Brute Force solution: [{0}]" + " Target:" + target, string.Join(", ", BruteForceTwoSum(nums, target)));
        }
        // one pass dictionary
        public static int[] TwoSum(int[] nums, int target)
            {
                HashSet<int> d = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int c = target - nums[i];
                    if (d.Contains(c))
                    {
                        return new int[] { Array.IndexOf(nums, c), i };
                    }
                    d.Add(nums[i]);
                }
                return null;
        }

        // brute force solution
        public static int[] BruteForceTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            // In case there is no solution, we'll just return null
            return null;
        }

    }
}
