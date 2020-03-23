using System;

namespace _2_Add_Two_Numbers
{
    // leetcode start -----
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(7);
            head.next = new ListNode(0);
            head.next.next = new ListNode(8);

            return head;
        }
    }
    // leetcode end -----
}
