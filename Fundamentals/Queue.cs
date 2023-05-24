using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class MyQueue<T> 
    {

        Node<T> Head = default!;
        public int Count { get; set; }


        public bool IsEmpty()        //returns true if the queue is empty and false is it isn’t
        {
            return Head == null;
            
        }

        public void Enqueue(T item)     // adds an item to the tail of the queue   
        {
            Node<T> node = new(item);

            if (IsEmpty())
            {
                Head = node;

            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }

            Count++;
        }

        public void Dequeue()  // removes and returns the item at the head of the queue
        {
            if (IsEmpty()) throw new InvalidOperationException("The stack is empty.");
            Head = Head.Next;
            Count--;
        }


       public int Size()    // shows the number of items currently in the queue
        {
            return Count;
        }    

    }

}
