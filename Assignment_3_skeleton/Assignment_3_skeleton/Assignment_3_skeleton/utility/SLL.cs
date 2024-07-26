using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/**
 * Name: Roman Sorokin, Mace Howald, Nasratullah Asadi
 * Date: 07/26/2024
 * Program Description: Implementation of the Singly Linked List (SLL) class.
 */

namespace Assignment_3_skeleton
{
    [Serializable]
    public class SLL : LinkedListADT
    {
        // Using the Node class and setting head and tail to null.
        Node head;
        Node tail;
        int size = 0;

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }
        public bool Empty
        {
            get
            {
                return (head == null);
            }
        }

        // Initalizes a new singly linked list with head and tail set to null.
        public SLL()
        {
            head = null;
            tail = null;
        }

        public void Append(object data)
        {
            {
                Node newNode = new Node(data);

                if (size == 0)
                {
                    head = newNode; // If the list is empty, the head becomes the new node
                    tail = newNode; // If the list is empty, the tail becomes the new node
                }
                else
                {
                    tail.Next = newNode; // If the list is not empty, the tail points to the new node
                    tail = newNode; // The tail becomes the new node
                }

                size++; // Increase the size by one to reflect the new node
            }
        }

        public void Clear()
        {
            head = tail = null;
            size = 0;
        }

        public bool Contains(object data)
        {
            // Start from the head
            Node current = head;
            {
                while (current != null)
                {
                    // Compare the data with current element
                    if (current.Element.Equals(data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }  
        }

        public void Delete(int index)
        {
            // First, check if index is less than 0 or greater than/equal to the size of the list. If this is the case, throw the IndexOutOfRangeException 
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }

            if (index == 0) // If the node to delete is the head node, update the head to point to the next node. If the list becomes empty after, update the tail to null.
            {
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
            }
            else // If index is greater than 0, iterate through the list to find the node before the node to be deleted (index - 1)
            {
                Node current = head;
                for (int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next; // This line bypasses the node at 'index' by pointing to the node after it 
                if (current.Next == null)
                {
                    tail = current; // If the removed node was the last node, update the tail
                }
            }

            size--; // Decrease size by one to reflect removing the node
        }

        public int IndexOf(object data)
        {
            Node current = head; // Sets the current node to the head
            int index = 0; // Sets the index to 0

            while (current != null)
            {
                if (current.Element.Equals(data)) // Iterates through the list and if the Element of the node matches the data, it returns the index
                {
                    return index;
                }

                current = current.Next; // If the head node does not match the data, go onto the next list and increase the index by 1
                index++;
            }

            return -1; // If the loop completes without finding the data, return -1
        }

        public void Insert(object data, int index)
        {
            // First, check if index is less than 0 or greater than/equal to the size of the list. If this is the case, throw the IndexOutOfRangeException 
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }

            Node newNode = new Node(data); // Creates a new node with specified data

            if (index == 0) // Inserts newNode at the head if index is 0
            {
                newNode.Next = head; // Points to the head
                head = newNode; // The head becomes the new node
                if (size == 0)
                {
                    tail = newNode; // If the list is empty, update the tail to the newNode
                }
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next; // Iterates through the list to find the node before the index
                }
                newNode.Next = current.Next; // The new node points to the node at the index
                current.Next = newNode; // The node at the previous index points to the new node

                if (newNode.Next == null)
                {
                    tail = newNode; // If the new node is inserted at the end, update the tail accordingly
                }
            }

            size++; // Increase the size by one to reflect the new node
        }

        public bool IsEmpty()
        {
            return Empty;
        }

        public void Prepend(object data)
        {
            Node newNode = new Node(data); // Creates a new node with specified data
            newNode.Next = head; // Points to the head
            head = newNode; // The head becomes the new node

            if (size == 0)
            {
                tail = newNode; // If the list is empty, update the tail to the newNode
            }

            size++; // Increase the size by one to reflect the new node
        }

        public void Replace(object data, int index)
        {
            // First, check if index is less than 0 or greater than/equal to the size of the list. If this is the case, throw the IndexOutOfRangeException 
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next; // Iterates through the list to find the node at the index
            }
            current.Element = data; // Replaces the data at the index with the new data
        }

        public object Retrieve(int index)
        {
            // First, check if index is less than 0 or greater than/equal to the size of the list. If this is the case, throw the IndexOutOfRangeException 
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next; // Iterates through the list to find the node at the index
            }
            return current.Element; // Returns the data at the index
        }

        public int Size()
        {
            return size;
        }
    }
}
