using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] sums = new int[] { 3, 2, 4 };
            int target = 2;
            int[] res = solution.TwoSum(sums, target);
            Console.WriteLine("[{0},{1}]", res[0], res[1]);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] sums, int target)
        {
            int[] res = new int[] { 0, 0 };
            for (int i = 0; i < sums.Length; i++)
            {
                for (int j = i + 1; j < sums.Length; j++)
                {
                    if (sums[i] + sums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }
            throw new ArgumentException ("不存在数组");
        }
    }
}
