using System;
namespace Stack_Queue
{
    class Program
    {
        static void Main()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            linkedList.AddNode(node1);
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);

            Stack stack = new Stack();
            stack.push(node1);
            stack.push(node2);
            stack.push(node3);
            stack.displayStack();



        }
    }
}