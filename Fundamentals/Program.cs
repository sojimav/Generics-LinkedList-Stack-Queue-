using System;


namespace Fundamentals
{
    public class Execute
    {
        static void Main()
        {
            SinglyLinkedList<int> list = new();
            Stacks<int> myStacks = new();
            MyQueue<int> order = new();

            Console.WriteLine("Testing My Linked List Methods");
            list.Add(1);
            list.Add(2);
            list.Add(6);
            list.Add(4);
            list.Add(5);
            list.Print();

            Console.WriteLine();
            Console.WriteLine("Remove 2 from the list");
            list.Remove(2);
            list.Print();
            Console.WriteLine($"The index of 6 is {list.Index(6)}");

            Console.WriteLine("\nTesting My Stack List Methods");
            myStacks.Push(1);
            myStacks.Push(2);
            myStacks.Push(3);
            myStacks.Push(4);
            myStacks.Push(5);
            
            
            Console.WriteLine($"\nI added {myStacks.Size()} items to my Stack");
            Console.WriteLine($"The last item in my stack is {myStacks.Peek()}");
            myStacks.Pop();
            Console.WriteLine($"I have removed 5 based on last in first out rule using the Pop() method" +
            $", now the last item in my stack is {myStacks.Peek()}");
           


            Console.WriteLine("\nTesting My Queue List Methods\n");
            order.Enqueue(1);
            order.Enqueue(2);
            order.Enqueue(3);
            order.Enqueue(4);
            
            
            Console.WriteLine($"I added {order.Size()} items to my Queue");
            order.Dequeue();
            Console.WriteLine($"I have removed 1 from the queue" +
                $" based on first in first out now the queue contains {order.Size()} items\n\n");
                     

        }
    }
}


