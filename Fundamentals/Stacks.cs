using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Fundamentals
{
    internal class Stacks<T>
    {

        private Node<T> Head = default!;

        public int Count { get; set; }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Push(T item)    // adds an item to the top of the stack  6,5,4,3
        {
            Node<T> node = new(item);
            if (IsEmpty())
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }

            Count++;
        }

        public T Pop()     // removes and returns the last item added to the stack  6,5,4,3
        {
            if (!IsEmpty())
            {
                Node<T> store = Head;
                Head = Head.Next;
                Count--;
                return store.Data;
            }
            else
                throw new InvalidOperationException("The stack is empty.");


        }

        public T Peek()          //returns the last item added to the stack
        {
            if (Head == null) throw new InvalidOperationException("The stack is empty.");
            return Head.Data;
        }


        public int Size()
        {
            return Count;
        }

        

    }
}
