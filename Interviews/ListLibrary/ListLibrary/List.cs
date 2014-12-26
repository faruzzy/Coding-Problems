using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    public class List: IEnumerable
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private int count = 0;

        /// <summary>
        /// Keeps track of the number of node in the List
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Default Constructor for creating a List
        /// </summary>
        public List()
        {
            firstNode = lastNode = null; 
        }

        public object this[int index]
        {
            get
            {
                int s = 0;
                ListNode current = firstNode;
                while(s != index)
                {
                    current = current.Next;
                    s++;
                }

                return current.Data;
            }
        }

        /// <summary>
        /// Check wether the List is empty
        /// </summary>
        /// <returns>True if the list is empty, otherwise, returns false</returns>
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void InsertAtFront(object valueItem)
        {
            if (IsEmpty())
                firstNode = lastNode = new ListNode(valueItem);
            else
                firstNode = new ListNode(valueItem, firstNode.Next);

            count++;
        }

        public void InsertAtBack(object valueItem)
        {
            if (IsEmpty())
                firstNode = lastNode = new ListNode(valueItem);
            else
                lastNode = lastNode.Next = new ListNode(valueItem);

            count++;
        }

        /// <summary>
        /// Helper function to Insert at the back of 
        /// the List.
        /// </summary>
        /// <param name="valueItem">The object to insert in the List</param>
        public void Add(object valueItem)
        {
            InsertAtBack(valueItem);
        }

        public object RemoveFromFront(object itemValue)
        {
            if (IsEmpty())
                throw new EmptyListException();

            object removedItem = firstNode.Data;

            if (firstNode == lastNode)
                firstNode = lastNode = null;
            else
                firstNode = firstNode.Next;

            count--;
            return removedItem;
        }

        public object RemoveFromBack(object itemValue)
        {
            if (IsEmpty())
                throw new EmptyListException();

            object removedItem = lastNode.Data;

            if (firstNode == lastNode)
                firstNode = lastNode = null;
            else
            {
                ListNode currentNode = firstNode;
                while (currentNode.Next != lastNode)
                    currentNode = currentNode.Next;

                lastNode = currentNode;
                lastNode.Next = null;
            }

            count--;
            return removedItem;
        }

        /// <summary>
        /// Prints the entire List
        /// </summary>
        public void Print()
        {
            if (IsEmpty())
                return;

            ListNode current = firstNode;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public IEnumerator GetEnumerator()
        {
            ListNode current = firstNode;

            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    public class EmptyListException : ApplicationException
    {
        public EmptyListException() : base()
        {

        }
    }
}
