using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class Stack
    {
        LinkedList linkedList;
        public Stack()
        {
            linkedList = new LinkedList();
        }
        public void push(Node node)
        {
            linkedList.AddNode(node);          
        }
        
        public void displayStack()
        {            
            linkedList.Stackdisplay();
        }
        public void Top()
        {
            var val = linkedList.Head;          
            Console.WriteLine("\n Top",+val.data);
        }
        public void Pop(Node node)
        {
            linkedList.Remove();
        }
    }
}
