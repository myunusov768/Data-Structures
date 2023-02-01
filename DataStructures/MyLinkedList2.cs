using System.Collections;
using System.Security.Cryptography;

namespace DataStructures
{
    

    public class MyLinkedList2<T> : IEnumerable<T>
    {
        public Node<T>? Head { get; private set; }
        public Node<T>? Tail { get; private set; }
        public int Count { get; private set; }

        public void Add(T value)
        {
            var node = new Node<T>(value);
            if (Head is null)
                Head = node;
            else 
                Tail.Next = node;
            Tail = node;
            Count++;
        }

        public void Delete(T value)
        {
            if (Head is not null && Head.Value.Equals(value))
            {
                Head = Head.Next;
                Count--;
                return;
            }
            var current = Head;
            while (current is not null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }
        public void AddInHead(T value)
        {
            var node = new Node<T>(value);
            var previous = Head;
            Head = node;
            Head.Next = previous;
            Count++;

        }
        public void AddInTail(T value)
        {
            var node = new Node<T>(value);
            Tail.Next = node;
            Tail = node;
            Count++;
        }


        public void AddInMiddle(T value)
        {
            var node = new Node<T>(value);
            if (Head is null)
            {
                Head = node;
                Tail = node;
                Count++;
                return;
            }

            int middle = Count / 2 + 1;
            int i = 0;
            var current = Head;
            while (i <= middle)
            {
                i++;
                if (i.Equals(middle))
                {
                    var previous = current.Next;
                    current.Next = node;
                    current.Next.Next = previous;
                    Count++;
                    break;
                }
                current = current.Next;
            }
        }

        public void DeleteTial()
        {
            if (Head is not null && Head.Next is null)
            {
                Head = null;
                Tail = null;
                Count--;
                return;
            }

            var current = Head;
            while (current is not null)
            {
                if (current.Next.Next is null)
                {
                    current.Next = current.Next.Next;
                    Tail= current.Next;
                    Count--;
                    break;
                }
                current = current.Next;
            }
        }

        public void Reverse()
        {
            MyLinkedList2<T> rev = new MyLinkedList2<T>();
            var current = Head;
            while (current is not null)
            {
                rev.AddInHead(current.Value);
                current = current.Next;
            }
            Head = rev.Head;
        }

        public bool Contains(T value)
        {
            var current = Head;
            while (current is not null)
            {
                if (current.MyEquals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
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
