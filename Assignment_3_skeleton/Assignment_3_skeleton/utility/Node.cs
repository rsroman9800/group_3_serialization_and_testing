using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    [Serializable]
    // Node class representing each element in the singly linked list
    public class Node
    {
        object element;
        Node next;

        // Initializes a Node object with the passed object and null next node.
        public Node(object o)
        {
            Element = o;
            Next = null;
        }

        // Initializes a Node object with the passed object and next node.
        public Node(object o, Node n)
        {
            this.Element = o;
            this.Next = n;
        }

        // Getters and setters for the element and next node.
        public object Element { get => element; set => element = value; }
        public Node Next { get => next; set => next = value; }
    }
}
