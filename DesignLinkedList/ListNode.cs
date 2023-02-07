namespace DesignLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode prev;
        public ListNode(int val)
        {
            this.val = val;
            this.prev = null;
            this.next = null;
        }
    }
}