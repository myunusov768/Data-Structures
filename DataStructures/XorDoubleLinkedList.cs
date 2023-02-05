using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XorDoubleLinkedList
{
    public class Node<T> : IEqualityComparer<T> 
        where T : struct
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        
        public int GetHashCode(T value)
        {
            throw new NotImplementedException();
        }

        public bool Equals(T x, T y)
        {
            if (x.Equals(y))
                return true;
            return false;
        }
    }
    public class XorDoubleLinkedList
    {
        

    }
}
