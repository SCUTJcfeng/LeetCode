using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(157848751));
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public  bool IsPalindrome(int x)
        {
            string s = Convert.ToString(x);
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;

        }
    }
}
