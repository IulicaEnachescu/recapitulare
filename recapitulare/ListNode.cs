using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recapitulare
{
    class ListNode
    { /*You are given two non-empty linked lists representing two non-negative integers.
        The digits are stored in reverse order and each of their nodes contain a single digit. 
        Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.*/
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode listSum = new ListNode(0);
            ListNode p = l1;
            ListNode q = l2;
            var curr = listSum;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0) curr.next = new ListNode(carry);
            return listSum.next;
        }
    }
}
