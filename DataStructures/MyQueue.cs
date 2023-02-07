using System;
using System.Collections;

namespace MyQueue
{
    public sealed class MyQueue<T> : IEnumerable<T>
    {
        private readonly int _top;
        private int _last;
        private readonly int _length;
        private T[] _array;
        public MyQueue(int length = 100) 
        {
            if (length <= 0)
                _length = 100;
            _length = length;
            _array = new T[length];
            _top = 0;
            _last = -1;
        }

        public void Enqueue(T value)
        {
            if (_top >= _length)
                throw new Exception();
            _array[++_last] = value;
        }

        public T Dequeue()
        {
            if(_last == -1)
                throw new Exception("Array is empty");
            T _returningValue = _array[_top];
            int i = 0;
            while (_last >= i)
            {
                _array[i] = _array[++i];
            }
            return _returningValue;
        }
        public T Peek()
        {
            if (_last is -1)
                return default;
            return _array[_top];
        }

        public bool IsFull()
        {
            if (_last == _length)
                return true;
            return false;
        }

        public bool IsEmpty()
        {
            if (_last < _length)
                return true;
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _last; i++)
                yield return _array[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
