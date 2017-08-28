using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] strs = { "1234", "12", "123" };
            Console.WriteLine(solution.LongestCommonPrefix(strs));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs != null && strs.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; ++j)
                {
                    if (strs[j].Length <= i || strs[j][i] != strs[0][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }

            }
            return strs[0];
        }
    }
}
