
namespace MyTree
{
    public sealed class Node<T> : IComparable
        where T : IComparable
    {
        public T Value { get; set; }
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }
        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public int CompareTo(object? obj)
        {
            if (obj is Node<T> item)
                return Value.CompareTo(item.Value);
            throw new ArgumentException();
        }
    }


    public sealed class MyTreeGeneric<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }
        
        public void Insert(T value)
        {
            var node = new Node<T>(value);
            if (Root == null)
            {
                Root= node;
                Count++;
                return;
            }
            Insert(Root, node);

        }

        
        public void Insert(Node<T> node, Node<T> newNode)
        {
            if (node != null)
            {
                if (newNode.CompareTo(node) == -1 || newNode.CompareTo(node) == 0)//menshe
                {
                    if (node.LeftNode == null)
                    {
                        node.LeftNode = newNode;
                        Count++;
                        return;
                    }
                    else
                        Insert(node.LeftNode, newNode);
                }
                if (newNode.CompareTo(node) == 1)//ne menshe
                {
                    if (node.RightNode == null)
                    {
                        node.RightNode = newNode;
                        Count++;
                        return;
                    }
                    else
                        Insert(node.RightNode, newNode);
                }
            }
        }
        public List<T> PreOrder()
        {
            if (Root == null)
                return new List<T>();
            return PreOrder(Root);
        }

        private List<T> PreOrder(Node<T> startNode)
        {
            var list = new List<T>();
            if (startNode != null)
            {
                list.Add(startNode.Value);
                if (startNode.LeftNode != null)
                {
                    list.AddRange(PreOrder(startNode.LeftNode));
                }
                if (startNode.RightNode != null)
                {
                    list.AddRange(PreOrder(startNode.RightNode));
                }
            }
            return list;
        }
        public List<T> PostOrder()
        {
            if (Root == null)
                return new List<T>();
            return PostOrder(Root);
        }
        private List<T> PostOrder(Node<T> startNode)
        {
            var list = new List<T>();
            if (startNode != null)
            {
                if (startNode.LeftNode != null)
                {
                    list.AddRange(PostOrder(startNode.LeftNode));
                }
                if (startNode.RightNode != null)
                {
                    list.AddRange(PostOrder(startNode.RightNode));
                }
                list.Add(startNode.Value);
            }
            return list;
        }
        public List<T> InOrder()
        {
            if (Root == null)
                return new List<T>();
            return InOrder(Root);
        }
        private List<T> InOrder(Node<T> startNode)
        {
            var list = new List<T>();
            if (startNode != null)
            {
                if (startNode.LeftNode != null)
                {
                    list.AddRange(InOrder(startNode.LeftNode));
                }
                list.Add(startNode.Value);
                if (startNode.RightNode != null)
                {
                    list.AddRange(InOrder
                        (startNode.RightNode));
                }
            }
            return list;
        }

    }
}
