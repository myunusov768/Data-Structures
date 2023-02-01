
using System.Collections;

namespace DataStructures
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }
        private T _value;

        public T Value 
        { 
            get => _value; 
            set
            {
                if (value is not null)
                    _value = value; 
            }
        }
        public Node<T> Next { get; set; }

        public bool MyEquals(T? value)
        {
            if(EqualityComparer<T>.Default.Equals( value , Value))
                return true;
            else return false;
        }
    }


    public class MyLinkedList<T>: IEnumerable<T>
    {
        public Node<T>? Head { get; private set; }
        public int Count { get; private set; }


        public void Add(T value)
        {
            var node = new Node<T>(value);
            if (Head is null)
            {
                Head = node;
                Count++;
                return;
            }

            var current = Head;
            while (current is not null) 
            {
                if (current.Next is null)
                {
                    current.Next = node;
                    Count++;
                    break;
                }
                current = current.Next;
            }
        }

        public void AddInHead(T value)
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

        public void AddInMiddle(T value)
        {
            var node = new Node<T>(value);
            if (Head is null)
            {
                Head = node;
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
                Count--;
            }

            var current = Head;
            while (current is not null)
            {
                if (current.Next.Next is null)
                {
                    current.Next = current.Next.Next;
                    Count--;
                    break;
                }
                current = current.Next;
            }
        }

        public void DeleteHead()
        {
            var previous = Head;
            if (previous is not null)
            {
                Head = previous.Next;
                Count--;
            }
        }

        public void Reverse()
        {
            MyLinkedList<T> rev = new MyLinkedList<T>();
            var current = Head;
            while (current is not null)
            {
                rev.AddInHead(current.Value);
                current = current.Next;
            }
            Head = rev.Head;
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
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
