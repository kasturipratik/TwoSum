using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine("Array : ");
            Console.WriteLine("[{0}]"+ " Target:" + target, string.Join(", ", TwoSum(nums, target)));
        }
        public static int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> d = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int c = target - nums[i];
                    int a;
                    if (d.TryGetValue(c, out a))
                    {
                        return new int[] { a, i };
                    }
                    d.Add(nums[i], i);
                }
                return null;
        }
        
    }
}
