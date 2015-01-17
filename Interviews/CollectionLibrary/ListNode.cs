using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLibrary
{
    public class ListNode
    {
        public IComparable Data { get; set; }
        public ListNode Next { get; set; }

        public ListNode(IComparable data)
            : this(data, null)
        {

        }

        public ListNode(IComparable data, ListNode next)
        {
            Data = data;
            Next = next;
        }

    }
}
