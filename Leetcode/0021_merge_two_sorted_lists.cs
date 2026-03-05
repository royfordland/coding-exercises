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
	public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
	{
		// This was listed as "Easy", but I would think it's more "Medium" if anything else.
		//
		// I had the initial code going of looping through the lists and keeping track of the values,
		// but I guess the catch was needing a base node of sorts as well.
		// Initially I tried working off of just the mergeList, but by the end of the method all you have
		// is basically the last added node. I guess I normally don't build my own linked lists.
		//
		// At first I started off working with list1 and currentNode1 to keep track of things, but
		// then I realized I could just with the lists directly, but that just complicated things more.
		var initialNode = new ListNode(0);
		var mergeList = initialNode;

		while (list1 != null && list2 != null)
		{
			if (list1.val <= list2.val)
			{
				mergeList.next = list1;
				list1 = list1.next;
			}
			else
			{
				mergeList.next = list2;
				list2 = list2.next;
			}

			mergeList = mergeList.next;
		}

		if (list1 != null)
		{ 
			mergeList.next = list1;
		}
		else if (list2 != null)
		{
			mergeList.next = list2;
		}

		return initialNode.next;
	}
}