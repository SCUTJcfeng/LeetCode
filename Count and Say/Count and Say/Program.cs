using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * The count-and-say sequence is the sequence of integers with the first five terms as following:

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.
Given an integer n, generate the nth term of the count-and-say sequence.

Note: Each term of the sequence of integers will be represented as a string.

Example 1:

Input: 1
Output: "1"
Example 2:

Input: 4
Output: "1211"
*/

namespace Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.CountAndSay(30));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n <= 1)
                return "1";
            return Say(CountAndSay(n - 1));
        }

        public string Say(string str)
        {
            string s = "";
            int count = 0;
            for (int i = 0; i < str.Length;)
            {
                for (int n = 1; n < 4; n++)
                {
                    while (i < str.Length && str[i] == n.ToString()[0])
                    {
                        count++;
                        i++;
                    }
                    if (count != 0)
                    {
                        s += count.ToString();
                        s += n.ToString();
                        count = 0;
                    }
                }
            }
            return s;
        }
    }
}
