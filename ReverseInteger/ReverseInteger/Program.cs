using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(154511515));
            Console.ReadLine();
        }

        public static int Reverse(int x)
        {
            long sum = 0;
            while (x != 0)
            {
                sum = sum * 10 + x % 10;
                x /= 10;
            }
            return (sum > int.MaxValue || sum < int.MinValue) ? 0 : (int)sum;
        }
    }
}
