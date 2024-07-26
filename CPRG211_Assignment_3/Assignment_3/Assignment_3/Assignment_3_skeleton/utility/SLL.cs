using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
	[Serializable]
	public class SLL : LinkedListADT
	{
		private Node head;
		private int count;

		public SLL()
		{
			this.head = null;
			this.count = 0;
		}

		public void Append(object data)
		{
			Node newNode = new Node(data);
			if (head == null)
			{
				head = newNode;
			}
			else
			{
				Node current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				current.Next = newNode;
			}
			count++;
		}

		public void Prepend(object data)
		{
			Node newNode = new Node(data);
			if (head == null)
			{
				head = newNode;
			}
			else
			{
				newNode.Next = head;
				head = newNode;
			}
			count++;
		}

		public void Insert(object data, int index)
		{
			if (index < 0 || index > count)
			{
				throw new IndexOutOfRangeException();
			}

			if (index == 0)
			{
				Prepend(data);
				return;
			}

			Node newNode = new Node(data);
			Node current = head;

			for (int i = 1; i < index; i++)
			{
				current = current.Next;
			}

			newNode.Next = current.Next;
			current.Next = newNode;
			count++;
		}

		public void Replace(object data, int index)
		{
			if (index < 0 || index >= count)
			{
				throw new IndexOutOfRangeException();
			}

			Node current = head;
			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}
			current.Data = data;
		}

		public void Delete(int index)
		{
			if (index < 0 || index >= count)
			{
				throw new IndexOutOfRangeException();
			}

			if (index == 0)
			{
				head = head.Next;
			}
			else
			{
				Node current = head;
				for (int i = 1; i < index; i++)
				{
					current = current.Next;
				}
				current.Next = current.Next.Next;
			}
			count--;
		}

		public object Retrieve(int index)
		{
			if (index < 0 || index >= count)
			{
				throw new IndexOutOfRangeException();
			}

			Node current = head;
			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}
			return current.Data;
		}

		public int IndexOf(object data)
		{
			Node current = head;
			for (int i = 0; i < count; i++)
			{
				if (current.Data.Equals(data))
				{
					return i;
				}
				current = current.Next;
			}
			return -1;
		}

		public bool Contains(object data)
		{
			return IndexOf(data) != -1;
		}

		public bool IsEmpty()
		{
			return count == 0;
		}

		public void Clear()
		{
			head = null;
			count = 0;
		}

		public int Size()
		{
			return count;
		}
	}

}
