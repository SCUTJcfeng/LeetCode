using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode head1, ListNode head2)
        {
            ListNode fakeHead = new ListNode(0);
            fakeHead.next = head1;
            ListNode pre = fakeHead;
            while (head1 != null && head2 != null)
            {
                if (head1.val < head2.val)
                {
                    head1 = head1.next;
                }
                else
                {
                    ListNode next = head2.next;
                    head2.next = pre.next;
                    pre.next = head2;
                    head2 = next;
                }
                pre = pre.next;
            }
            if (head2 != null)
            {
                pre.next = head2;
            }
            return fakeHead.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
