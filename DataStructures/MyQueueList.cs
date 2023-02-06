
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MyQueueList
{
    public class Node<T>: IEqualityComparer<T>
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

        public bool Equals(T? x, T? y)
        {
            if(x.Equals(y))
                return true;
            return false;
        }

        public int GetHashCode([DisallowNull] T value)
        {
            return value.GetHashCode();
        }
    }

    public class MyQueueList<T>: IEnumerable<T>
    {
        public int Count { get; private set; }
        public Node<T> Head { get; private set; }
        
        public void Enqueue(T value)
        {
            var newNode = new Node<T>(value);
            if (Head is null) 
            {
                Head = newNode;
                Count++;
                return;
            }
            var current = Head;
            while (current is not null)
            {
                if (current.Next is null)
                {
                    current.Next = newNode;
                    Count++;
                    return;
                }
                current = current.Next;
            }
        }

        public bool Dequeue()
        {
            if(Head is null)
                return false;
            var previous = Head.Next;
            Head = previous;
            Count--;
            return true;
        }

        public T Peek()
        {
            if (Head is null)
                return default;
            return Head.Value;
        }
        public bool Contains(T item)
        {
            if (Head is null)
                return false;
            var current = Head;
            while (current is not null)
            {
                if(current.Equals(current.Value,item))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public T[] SplitListToArrayFromIndex(int arrayIndex)
        {
            if(arrayIndex > Count || arrayIndex <=0)
                return null;
            
            if (Head is null)
                return null;
            T[] array = new T[Count - arrayIndex + 1];
            int i = 1;
            int j = 0;
            var current = Head;
            while (current is not null)
            {
                if (i >= arrayIndex)
                {
                    array[j] = current.Value;
                    j++;
                }
                current= current.Next;
                i++;
            }
            return array;
        }
        public T[] ToArray()
        {
            if (Head is null)
                return null;
            T[] array = new T[Count];
            var current = Head;
            int i = 0;
            while (current is not null)
            {
                if( i < Count)
                    array[i] = current.Value;
                i++;
                current= current.Next;
            }
            return array;
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
