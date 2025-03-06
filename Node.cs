using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace njfrfr
{
    public class Node
    {
        public int Data;
        public Node Prev;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }
}
