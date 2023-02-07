using ListNodeClass;
ListNode five = new ListNode(5);
ListNode four = new ListNode(4, five);
ListNode three = new ListNode(3, four);
ListNode two =  new ListNode(2, three);
ListNode one = new ListNode(1, two);
ReverseLinkedList(one);

#region Iterative Approach
//     // Time Complexity : O(n)
//     // Memory Complexity : O(1)
// ListNode ReverseLinkedList (ListNode head)
// {
//     // Using two pointers
//     // current is always start with the head
//     ListNode current = head;
//     // previous needs to start as null otherwise crash the first
//     // iteration
//     ListNode previous = null;
//     // while the current is not null, to iterate through every
//     // node on the list
//     while(current != null)
//     {
//         // Aux is needed to declare inside the loop
//         // because otherwise it gets an exception.
//         // and then start the process
//         // 1. save the next number in the list to the aux
//         var aux = current.next;
//         // 2. break / reassign the value of the next,
//         // to the previous node
//         current.next = previous;
//         // 3.- previous becomes the new current
//         // so that way you never lose the prev value
//         previous = current;
//         // 4.- and then move the current to the next node on the list
//         current = aux;
//     }
//     // why return previous instead of current?
//     // because if we iterate trough every node and in the last setp
//     // we move current, current will be assigned at the last
//     // iteration to null
//     return previous;
// }
#endregion

#region Recursive Approach
// Time : O(n)
// Memory : O(n)
    ListNode ReverseLinkedList(ListNode head)
    {
        // base Case
        if(head is null)
        {
            return null;
        }
        // Get the new head to store the current value
        ListNode newHead = head;
        // if head.next is null
        // that means that we are in the last node of the list
        // we need to reverse from this
        if(head.next != null)
        {

            // if there's still nodes left on the list
            // we need to iterate trough them with recursion
            // until we get to the last one to break the next link
            newHead = ReverseLinkedList(head.next);
            // when we return to the previous recursion
            // we broke already the link of the next
            // and assign the next node of the next node
            // to the actual head
            // this is the tricky part
            head.next.next = head;
        }
        // if we get to the last part then the previous if is not met
        // and then we break the link of the actual node
        head.next = null;
        return newHead;
    }
#endregion