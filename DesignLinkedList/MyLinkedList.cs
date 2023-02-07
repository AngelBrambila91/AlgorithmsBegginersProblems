namespace DesignLinkedList
{
    public class MyLinkedList
    {
        // This approach creates 2 dummy nodes at the start and at the end of the double linked list
        public ListNode left;
        public ListNode right;
        // Current is for getting the index
        public ListNode current;
        public MyLinkedList()
        {
            // create left and right with null or 0 values
            this.left = new ListNode(0);
            this.right = new ListNode(0);
            // and connect them
            this.left.next = this.right;
            this.right.prev = this.left;
        }

        public int Get(int index)
        {
            // current is always to the first "real" element
            current = this.left.next;
            // iterate through the entire list until we find the element to get the index
            while (current != null && index > 0)
            {
                // update current to the next one
                current = current.next;
                index -= 1;
            }
            // we got to the desired index :D!
            if (current != null && current != this.right && index == 0)
            {
                // return the val
                return current.val;
            }
            // if we iterate trough the entire list and not find the element, return -1
            // this is an specification
            return -1;
        }

        public void AddAtHead(int val)
        {
            // Add at head is the easiest one
            // because we have a left one we can always break the link
            // and reconnect to the new value
            ListNode node = new ListNode(val);
            ListNode next = this.left.next;
            ListNode prev = this.left;
            prev.next = node;
            node.prev = prev;
            node.next = next;
            next.prev = node;
        }

        public void AddAtTail(int val)
        {
            // Add at tail is the same ass add at head but taking reference the right node
            ListNode node = new ListNode(val);
            ListNode next = this.right;
            ListNode prev = this.right.prev;
            prev.next = node;
            node.prev = prev;
            node.next = next;
            next.prev = node;
        }

        public void AddAtIndex(int index, int val)
        {
            ListNode next = this.left.next;
            if (next != null && index == 0)
            {
                ListNode node = new ListNode(val);
                ListNode prev = next.prev;
                node.next = next;
                node.prev = prev;
                next.prev = node;
                prev.next = node;
            }
            while (next != null && index > 0)
            {
                index -= 1;
                next = next.next;
                if (next != null && index == 0)
                {
                    ListNode node = new ListNode(val);
                    ListNode prev = next.prev;
                    node.next = next;
                    node.prev = prev;
                    next.prev = node;
                    prev.next = node;
                }
            }
        }

        public void DeleteAtIndex(int index)
        {
            ListNode node = this.left.next;
            if (node != null && node != this.right && index == 0)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
            }
            while (node != null && index > 0)
            {
                index -= 1;
                node = node.next;
                if (node != null && node != this.right && index == 0)
                {
                    node.prev.next = node.next;
                    node.next.prev = node.prev;
                }
            }
        } 
    }
}