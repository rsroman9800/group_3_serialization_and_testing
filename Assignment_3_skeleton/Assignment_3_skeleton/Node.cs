using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class Node
    {
        public object Data;
        public Node Next;

        public Node(object Data)
        {
            this.Data = Data;
            this.Next = null;
        }
    }
}
