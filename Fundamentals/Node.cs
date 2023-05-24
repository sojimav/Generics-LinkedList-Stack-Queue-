using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
     public class Node<T>
    {
        internal Node<T> Next = default!;
        internal T Data;

        public Node(T data)
        {
            Data = data;
        }
    }
}
