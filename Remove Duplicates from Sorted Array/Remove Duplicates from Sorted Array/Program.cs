using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 4, 5 };
            Solution solution = new Solution();
            Console.WriteLine(solution.RemoveDuplicates(nums));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int temp = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[temp] != nums[i])
                {
                    temp++;
                    nums[temp] = nums[i];
                }
            }
            return temp + 1;
        }
    }
}
