using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLibrary
{
    public class List : IEnumerable
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private int count = 0;
        public int Count
        {
            get { return count; }
        }

        public List()
        {
            firstNode = lastNode = null;
        }

        public IComparable this[int index]
        {
            get
            {
                int s = 0;
                ListNode currentNode = firstNode;

                while (s++ != index)
                    currentNode = currentNode.Next;

                return currentNode.Data;
            }
            set
            {
                int s = 0;
                ListNode currentNode = firstNode;

                while (s++ != index)
                    currentNode = currentNode.Next;

                currentNode.Data = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            ListNode currentNode = firstNode;
            while (currentNode != null)
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;
            }
        }

        public void Add(IComparable insertValue)
        {
            InsertAtBack(insertValue);
        }

        public IComparable Remove()
        {
            return RemoveFromBack();
        }

        private IComparable RemoveFromBack()
        {
            if (IsEmpty()) throw new ListEmptyException();
            IComparable removedItem = lastNode.Data;

            ListNode currentNode = firstNode;
            while (currentNode.Next != lastNode)
                currentNode = currentNode.Next;

            lastNode = currentNode;
            lastNode.Next = null;

            count--;
            return removedItem;
        }

        public bool Contains(IComparable searchValue)
        {
            foreach (var item in this)
                if (item == searchValue)
                    return true;

            return false;
        }

        public int IndexOf(IComparable searchValue)
        {
            int index = 0;
            foreach (var item in this)
                if (item == searchValue) break;
                else index++;

            return index;
        }

        public void Print()
        {
            ListNode currentNode = firstNode;
            while (currentNode.Next != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }

        public void Clear()
        {
            firstNode = lastNode = null;
            count = 0;
        }

        private void InsertAtBack(IComparable insertValue)
        {
            if (IsEmpty())
                firstNode = lastNode = new ListNode(insertValue);
            else
                lastNode = lastNode.Next = new ListNode(insertValue);

            count++;
        }

        private bool IsEmpty()
        {
            return firstNode == null;
        }
    }

    internal class ListEmptyException : ApplicationException
    {
        public ListEmptyException()
            : base()
        {

        }
    }
}
