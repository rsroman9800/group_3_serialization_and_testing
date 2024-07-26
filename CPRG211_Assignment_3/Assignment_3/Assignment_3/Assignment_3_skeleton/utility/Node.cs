using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
	[Serializable]
	public class Node
	{
		public Object Data { get; set; }
		public Node Next { get; set; }

		public Node(Object data)
		{
			this.Data = data;
			this.Next = null;
		}
	}

}
