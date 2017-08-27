using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.RomanToInt("MDCCCLXXXIV"));
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> dt = new Dictionary<string, int>();

            dt.Add("I", 1);
            dt.Add("X", 10);
            dt.Add("C", 100);
            dt.Add("M", 1000);
            dt.Add("V", 5);
            dt.Add("L", 50);
            dt.Add("D", 500);

            char[] chr = s.ToCharArray();
            int sum = 0;
            for (int i = 0; i < chr.Length; i++)
            {
                if (i + 1 <= chr.Length - 1 && dt[chr[i].ToString()] < dt[chr[i + 1].ToString()])
                {
                    sum += dt[chr[i + 1].ToString()] - dt[chr[i].ToString()];
                    i++;
                }
                else sum += dt[chr[i].ToString()];
            }
            return sum;
        }
    }
}
