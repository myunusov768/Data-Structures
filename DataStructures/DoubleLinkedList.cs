using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace DoubleLinkedList
{
    public class Node<T> : IEqualityComparer<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public bool Equals(T? x, T? y)
        {
            if(x.Equals(y))
                return true;
            return false;
        }

        public int GetHashCode( T value)
        {
            throw new NotImplementedException();
        }
    }

    public class DoubleLinkedList<T> : IEnumerable<Node<T>>
    {
        public Node<T> Head { get; private set; }
        public int Count { get; private set; }


        public void Add(T value)
        {
            //В двусвязные списки новая значение добавится в голове, а в односвяязанный в хвост
            var node = new Node<T>(value);
            if (Head is null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
            Count++;
        }

        public Node<T> FindByValue(T value)
        {
            if (Head is null)
                return null;
            if(Head.Equals(value, Head.Value))
                return Head;
            var current = Head;
            while (current is not null) 
            {
                if(current.Equals(value, current.Value))
                    return current;
                current = current.Next;
            }
            return null;
        }

        
        public bool DeleteByValue(T value)
        {
            if(Head is null)
                return false;
            if (Head.Equals(value, Head.Value))
            {
                var nextN = Head.Next;
                nextN.Previous = null;
                Head= nextN;

                Count--;
                return true;
            }

            var searchingNode = FindByValue(value);

            var prevNode = searchingNode.Previous;
            var nextNode = searchingNode.Next;


            if (nextNode is not null && prevNode is not null)
            {
                prevNode.Next.Next = nextNode;
            }
            if (nextNode is null)
            {
                prevNode.Next = nextNode;
            }
            if (prevNode is null)
            {
                nextNode.Previous = prevNode;
            }
            Count--;
            return false;
        }


        public bool AddTail(T value)
        {
            var node = new Node<T>(value);
            if (Head is null)
            {
                Head = node;
                Count++;
                return true;
            }

            var current = Head;
            while (current is not null)
            {
                if (current.Next is null)
                {
                    current.Next = node;
                    node.Previous = current;
                    Count++;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public bool DeleteTail()
        {
            if (Head is null)
            {
                return false;
            }
            if (Head.Next is null)
            {
                Head = null;
                Count--;
                return true;
            }

            var current = Head;
            while (current is not null)
            {
                if (current.Next.Next is null)
                {
                    current.Next = null;
                    Count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public bool DeleteHead()
        {
            if (Head is null)
            {
                return false;
            }
            if (Head.Next is null)
            {
                Head = null;
                Count--;
                return true;
            }

            var nextNode = Head.Next;
            nextNode.Previous = null;
            Head= nextNode;
            Count--;
            return true;
        }

        public bool Reverse()
        {
            if (Head is null)
            {
                return false;
            }
            if (Head.Next is null)
            {
                return true;
            }

            var current = Head;
            DoubleLinkedList<T> rev = new DoubleLinkedList<T>();

            while (current is not null)
            {
                rev.Add(current.Value);
                current= current.Next;
            }
            Head = rev.Head;
            return true;
        }



        public void Clear()
        {
            Head = null;
            Count = 0;
        }


        public IEnumerator<Node<T>> GetEnumerator()
        {
            var current = Head;
            while (current is not null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
