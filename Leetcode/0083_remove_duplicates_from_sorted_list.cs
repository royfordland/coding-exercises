/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution
{
	public ListNode DeleteDuplicates(ListNode head)
	{
		// loop through the list.
		// if the .val value is the same as .next.val, then set .next to .next.next.
		// this will skip the next item in the list of nodes.
		// I suppose it's technically not deleting, but instead reassigning one of the
		// ListNodes to a higher up ListNode (as in; reassign listnode #3 to listnode #2
		// in case #1 and #2 are the same, reassigning #3 to #2 then makes #1 and #2 no
		// longer the same which is the goal here)

		// note: I forgot to set his on a separate pointer and work directly with "head",
		// and then I end up with just the last value in the list.

		var current = head;

		while (current != null && current.next != null)
		{
			if (current.val == current.next.val)
			{
				current.next = current.next.next;
			}
			else
			{
				current = current.next;
			}
		}

		return head;
	}
}