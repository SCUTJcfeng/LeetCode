using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    /*
    Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsValid("){"));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0 || s.Length % 2 == 1)
                return false;
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                        return false;
                    if (c == ')' && stack.Peek() != '(')
                        return false;
                    if (c == ']' && stack.Peek() != '[')
                        return false;
                    if (c == '}' && stack.Peek() != '{')
                        return false;
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
                return true;
            return false;
        }
    }
}
