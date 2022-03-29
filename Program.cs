using System;
namespace Stack_Queue
{
    class Program
    {
        static void Main()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            Stack stack = new Stack();
            stack.push(node1);
            stack.push(node2);
            stack.push(node3);
            stack.displayStack();
            stack.Top();
            stack.displayStack();
            stack.Pop(node1);
            stack.Pop(node2);
            stack.Pop(node3);
            stack.displayStack();
            Queue queue = new Queue();
            queue.enqueue(node1);
            queue.enqueue(node2);
            queue.enqueue(node3);
            queue.display();
            queue.Top();
            queue.display();
            queue.dequeue();
            queue.display();

        }
    }
}