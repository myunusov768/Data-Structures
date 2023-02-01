using System.Collections;
using System.Security.Cryptography;

namespace DataStructures
{
    

    public class MyLinkedList2<T> : IEnumerable<T>
    {
        public Node<T>? Head { get; private set; }
        public int Count { get; private set; }

        public void AddR(T value)
        {
            var node = new Node<T>(value);
            if (Head is null)
            {
                Head = node;
                Count++;
                return;
            }
            if (Head is not null)
            {
                var current = Head;
                Head = node;
                Head.Next = current;
            }
            

        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current is not null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
