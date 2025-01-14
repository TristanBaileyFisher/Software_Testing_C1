﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLLNode
    {
        public int num;   // field of the node
        public DLLNode next; // pointer to the next node
        public DLLNode previous; // pointer to the previous node
        public DLLNode (int num)
        {
            this.num = num;
            next = null;
            previous = null;
        } // end of constructor

        public bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }


    } // end of class DLLNode
}
