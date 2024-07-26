using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {

        public Node head;
        public Node tail;
        public int count;

        public SLL()
        {
            this.head = null;
            this.tail = null;
        }


        // Insert node at the END of the list
        public void Append(object data)
        {
            //throw new NotImplementedException();
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node last = GetLastNode();
            last.Next = newNode;
        }


        // Clear all items in list
        public void Clear()
        {
            //throw new NotImplementedException();

            head = null;
        }


        // Check if list contains a specific item
        public bool Contains(object data)
        {
            //throw new NotImplementedException();

            int index = IndexOf(data);

            if (index == -1)
            {
                return false;
            }

            return true;
        }



        // Remove an item at a specific index
        public void Delete(int index)
        {
            //throw new NotImplementedException();

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index must greater than 0");
            }

            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty");
            }

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current.Next == null)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            current.Next = current.Next.Next;
        }


        // Get index of specific item
        public int IndexOf(object data)
        {
            //throw new NotImplementedException();

            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1; // Return -1 if data not found
        }


        // Insert item at specific index
        public void Insert(object data, int index)
        {
            //throw new NotImplementedException();
            Node newNode = new Node(data);

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index must be greater than 0");
            }

            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }


            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                current = current.Next;
            }

            if (current == null)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public bool IsEmpty()
        {
            //throw new NotImplementedException();
            return head == null;
        }

        // Insert node at the START of the list
        public void Prepend(object data)
        {
            //throw new NotImplementedException();
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }


        // Replace item at specific index
        public void Replace(object data, int index)
        {
            //throw new NotImplementedException();

            Delete(index);
            Insert(data, index);
        }


        // Get item at specific index
        public object Retrieve(int index)
        {
            //throw new NotImplementedException();

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index must be greater than 0");
            }

            Node current = head;
            int currentIndex = 0;

            while (current != null)
            {
                if (currentIndex == index)
                {
                    return current.Data;
                }

                current = current.Next;
                currentIndex++;
            }

            throw new ArgumentOutOfRangeException("Index out of range");

        }


        // Get total number of items in list
        public int Size()
        {
            //throw new NotImplementedException();

            Node current = head;
            count = 0;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;

        }

        // Get the last node in the list
        public Node GetLastNode()
        {
            Node temp = head;
            while (temp != null && temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
    }
}
