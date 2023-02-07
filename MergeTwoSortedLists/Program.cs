using MergeTwoSortedLists;

// List 1-> 1,2,4
ListNode c = new ListNode(4);
ListNode b = new ListNode(2, c);
ListNode a = new ListNode(1, b);
// List 2-> 1,3,4
ListNode d = new ListNode(4);
ListNode e = new ListNode(3, d);
ListNode f = new ListNode(1, e);

Console.WriteLine(MergeTwoLists (a, f));

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    // dummy is when youre inserting empty (one or two cases have them)
    ListNode dummy = new ListNode();
    // tail is assigned to dummy
    ListNode tail = dummy;
    // when the other list is empty just return the first one like it is
    if(list1 is null)
    {
        return list2;
    }
    if(list2 is null)
    {
        return list1;
    }
    // the condition is when both lists are not empty
    while(list1 != null && list2 != null)
    {
        // just check if the value is < the other one
        if(list1.val < list2.val)
        {
            // if it does then assign and add the node to the tail
            tail.next = list1;
            // upgrade the pointer on L1
            list1 = list1.next;
        }
        // other wise is > or equal to the other one
        else
        {
            tail.next = list2;
            // upgrade the pointer on L2
            list2 = list2.next;
        }
        // upgrade tail
        tail = tail.next;
    }

    // this last if is when finish iterating through one list and the other one
    // still has elements to iterate through
    if(list1 != null)
    {
        tail.next = list1;
    }
    else
    {
        tail.next = list2;
    }
    return dummy.next;
}