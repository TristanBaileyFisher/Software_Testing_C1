using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {

            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
                p.previous = tail;
            }
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = this.head;
                this.head.previous = p;
                head = p;
            }
        } // end of addToHead

        public void removeHead() //original removHead typo
        {



            if (head == null)
                return;

            head = head.next;
            if(head != null)
            {
                head.previous = null;

            }
            else
            {
                tail = null;
            }
        } // removeHead

        public void removeTail() //original did not remove the tail
        {
            if (this.tail == null) return;
            if (this.head == this.tail)
            {
             this.head = null;
             this.tail = null;
            }
            else
            {
             this.tail = this.tail.previous;
             this.tail.next = null; // Update the next pointer of the new tail to null
            }
        } // remove tail

        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            DLLNode p = head;
            while (p != null) //original code did not handle the p correctly
            {
                if (p.num == num)
                    return p;
                p = p.next;
            }
            return null;
        } // end of search (return pionter to the node);

        public void removeNode(DLLNode p)
        {
            if (p == null)
            {
                return; // Handle case where p is null
            }

            if (p == this.head && p == this.tail)
            { // Only node in the list
                this.head = null;
                this.tail = null;
            }
            else if (p == this.head)
            { // Node is head
                this.head = p.next;
                this.head.previous = null;
            }
            else if (p == this.tail)
            { // Node is tail
                this.tail = p.previous;
                this.tail.next = null;
            }
            else
            { // Node is somewhere in the middle
                p.next.previous = p.previous;
                p.previous.next = p.next;
            }

            // Clear references to avoid dangling references
            p.next = null;
            p.previous = null;
        }


        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next; // Advance p by one node
            }
            return tot;
        }

    } // end of DLList class
}
