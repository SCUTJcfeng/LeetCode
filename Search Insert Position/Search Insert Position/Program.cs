using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0
*/


namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 5 };
            Solution solution = new Solution();
            Console.WriteLine(solution.SearchInsert(nums, 0));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0|| nums[0] >= target)
                return 0;
            int index = Array.IndexOf(nums, target);
            if (index != -1)
                return index;
            for (int i = 0; i < nums.Length; i++)
                if (i + 1 < nums.Length && nums[i] <= target && target <= nums[i + 1])
                    return i + 1;
            return nums.Length;
        }
    }
}
