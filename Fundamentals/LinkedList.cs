using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class SinglyLinkedList<T> 
    {
        private Node<T>? Head;            // Head Node that would subsquently point to the next nodes in the Linked list.
        private int Size { get; set; }   //  tracks the size of the List as we utilize the methods.


        public int Add(T data)
        {
            Node<T> newNode = new(data);

            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> present = Head;

                while (present.Next != null)
                {
                    present = present.Next;
                }

                present.Next = newNode;
            }
                Size++;
             return Size;
        }

        public bool Remove(T data)
        {  
            if (Head == null) return false;      
            if (Head.Data!.Equals(data))
            {
                Head = Head.Next;
                Size--;
                return true;

            }
            else
            {
                Node<T> present = Head;
                while (present.Next != null && !present.Next.Data!.Equals(data))
                {
                    present = present.Next;
                }

                if(present.Next != null)
                {
                    present.Next = present.Next.Next;
                    Size--;
                    return true;
                }
            }

            return false;
        }

        public bool Check(T item)
        {
            if (Head == null) return false;
            if (Head.Data!.Equals(item))
            {
                return true;
            }
            else
            {
                Node<T> present = Head;
                while(present.Next != null && !present.Data!.Equals(item))
                {
                    present = present.Next;
                }
                if(present.Next != null)
                {
                    return true;
                }
            }

            return false;
        }

         public int Index(T item)
        {
            int index = 0;
            Node<T> present = Head!;

            while(present != null)
            {
                if(present.Data!.Equals(item)) return index;
                present = present.Next;
                index++;
            }

              return -1;
        }


        public void Print()
        {
            
            Node<T> current = Head!;
            while (current != null)
            {
                Console.WriteLine(current!.Data);
                current = current.Next;            
               
            }

           
        }

    }

}
