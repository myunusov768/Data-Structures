using System.Collections;
namespace MyStackList
{
   

    //Работает по механизму Last-in-first-out
    public class MyStackList<T> : IEnumerable<T>
    {
        private readonly T[] nodeArray;
        public int Length { get; private set; }
        private int top = -1;

        public MyStackList(int count = 1000) 
        {
            Length= count;
            nodeArray = new T[count];
        }

        public void Push(T value)
        {
            if (top == Length - 1)
                throw new Exception("Array is full!");
            nodeArray[++top] = value;
        }
        public void Pop() 
        {
            if (top == -1)
                throw new ArgumentNullException();
            nodeArray[top] = default;
            top--;
        }
        
        public T Peek() 
        {
            if(top == -1)
                throw new ArgumentNullException();
            return nodeArray[top];
        }
        public bool IsFull()
        {
            if(top == Length-1)
                return true;
            return false;
        }
        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top; i >= 0; i--)
                yield return nodeArray[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
