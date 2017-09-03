using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

For example:

Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

Follow up:
Could you do it without any loop/recursion in O(1) runtime?
*/

namespace Add_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.AddDigits(124548));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int AddDigits(int num)
        {
            if (num < 10)
                return num;

            while (true)
            {
                num = Add(num);
                if (num < 10)
                    return num;
            }
        }
        public int Add(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
