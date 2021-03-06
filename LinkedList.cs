using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void Remove()
        {
            if (Head == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n pop : {0}",Head.data);
            Head=Head.next;
        }
        public void Remove_()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine("\n dequeue: {0}", Head.data);
            Head = Head.next;
        }

        public void display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        Console.Write("->");
                    }
                    temp = temp.next;
                }
            }
        }


    }
}
