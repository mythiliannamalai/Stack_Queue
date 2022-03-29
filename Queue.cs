using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class Queue
    {
        LinkedList linkedList;
        public Queue()
        {
            linkedList = new LinkedList();
        }
        public void enqueue(Node node)
        {
            linkedList.AddNode(node);
        }
        public void display()
        {
            Console.WriteLine("Queue");
            linkedList.display();
        }
        public void Top()
        {
            var val = linkedList.Head;
            Console.WriteLine("\n",+val.data);
        }
        public void dequeue()
        {
            linkedList.Remove_();
        }

    }
}
