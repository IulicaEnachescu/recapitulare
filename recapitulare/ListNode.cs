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
        public bool IsPalindrome1(ListNode head)
        {//var 1
            ListNode node = head;
            List<int> list = new List<int>();
            //int count = 0;
            //list.Add(node.val);
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            int first = 0;
            int last = list.Count() - 1;
            while (first < last)
            {
                if (list.ElementAt(first) != list.ElementAt(last)) return false;
                else
                {
                    first++;
                    last++;
                }
            }
            return true;
        }
        public ListNode Reverse(ListNode node)
        {//for palindrome
            ListNode newH = null;
            while (node != null)
            {
                ListNode next = node.next;
                node.next = newH;
                newH = node;
                node = next;
            }
            return newH;
        }
       
        

        public bool isPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }
            ListNode fast = head.next; // made the slow to be one node before the second half.
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            ListNode half = slow.next;
            slow.next = null;
            ListNode h = Reverse(half);
            while (head != null && h != null)
            {
                if (head.val != h.val)
                {
                    return false;
                }
                head = head.next;
                h = h.next;
            }
            return true;
        }
    }
}
