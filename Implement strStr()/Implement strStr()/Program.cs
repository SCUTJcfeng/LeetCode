using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

namespace Implement_strStr__
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.StrStr("1234456789", "456"));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            var i = 0;
            while (i < haystack.Length - needle.Length + 1)
            {
                var k = i;
                while (k < haystack.Length - needle.Length + 1)
                {
                    var s = haystack.Substring(k, needle.Length);
                    if (s == needle)
                    {
                        return k;
                    }
                    k++;
                }
                i++;
            }
            return -1;
        }
    }
}
