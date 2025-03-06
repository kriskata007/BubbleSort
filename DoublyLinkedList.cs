using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace njfrfr
{
    public class DoublyLinkedList
    {
        public Node Head;

        public void AddToEnd(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        public void Reverse()
        {
            Node temp = null;
            Node current = Head;


            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                current = current.Prev;
            }


            if (temp != null)
            {
                Head = temp.Prev;
            }
        }

        public void PrintList()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
