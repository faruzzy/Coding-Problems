using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    public class ListNode
    {
        /// <summary>
        /// Reference to the next node
        /// </summary>
        public ListNode Next { get; set; }

        public object Data { get; set; }

        public ListNode(object dataValue) : this(dataValue, null)
        {

        }

        public ListNode(object dataValue, ListNode next)
        {
            Data = dataValue;
            Next = next;
        }
    }
}
