
namespace MyTree
{
    enum Vector
    {
        left,
        right
    }

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

        
        private void Insert(Node<T> node, Node<T> newNode)
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


        public bool Remove(T value)
        {
            if (Root == null)
                return false;
            var _deletedNode = new Node<T>(value);
            if (_deletedNode.CompareTo(Root) == 0)
            {
                var leftNode = Root.LeftNode;
                Root = Root.RightNode;
                FindMinNode(Root, leftNode);
                Count--;
                return true;
            }
            

            return Remove(Root, _deletedNode);
        }
        private bool Remove(Node<T> node, Node<T> deletedNode)
        {
            if (node != null)
            {
                if (deletedNode.CompareTo(node.LeftNode) == -1 || deletedNode.CompareTo(node.LeftNode) == 0)
                {
                    if (deletedNode.CompareTo(node.LeftNode) == 0)
                    {
                        Delete(previousNode: node, node.LeftNode, vector: Vector.left);
                        Count--;
                        return true;
                    }
                    else
                    {
                        Remove(node.LeftNode, deletedNode);
                    }
                }
                if (deletedNode.CompareTo(node.RightNode) == 1 || deletedNode.CompareTo(node.RightNode) == 0)
                {
                    if (deletedNode.CompareTo(node.RightNode) == 0)
                    {
                        Delete(previousNode: node, node.RightNode, vector: Vector.right);
                        Count--;
                        return true;
                    }
                    else
                    {
                        Remove(node.RightNode, deletedNode);
                    }
                }
                
            }
            return false;
        }

        private void Delete(Node<T> previousNode, Node<T> currentNodeForDelete, Vector vector)
        {
            if (vector == Vector.right)
            {
                if (currentNodeForDelete.LeftNode == null && currentNodeForDelete.RightNode == null)
                {
                    currentNodeForDelete = null;
                    return;
                }
                if (currentNodeForDelete.LeftNode == null)
                {
                    previousNode.RightNode = currentNodeForDelete.RightNode;
                    return;
                }
                if (currentNodeForDelete.RightNode == null)
                {
                    previousNode.RightNode = currentNodeForDelete.LeftNode;
                    return;
                }
                
                if (currentNodeForDelete.LeftNode != null && currentNodeForDelete.RightNode != null)
                {
                    var leftNode = currentNodeForDelete.LeftNode;
                    previousNode.RightNode = currentNodeForDelete.RightNode;
                    FindMinNode(currentNodeForDelete, leftNode);
                    return;
                }
            }
            if (vector == Vector.left)
            {
                if (currentNodeForDelete.LeftNode == null && currentNodeForDelete.RightNode == null)
                {
                    currentNodeForDelete = null;
                    return;
                }
                if (currentNodeForDelete.RightNode == null)
                {
                    previousNode.LeftNode = currentNodeForDelete.LeftNode;
                    return;
                }
                if (currentNodeForDelete.LeftNode == null)
                {
                    previousNode.LeftNode = currentNodeForDelete.RightNode;
                    return;
                }
                if (currentNodeForDelete.LeftNode != null && currentNodeForDelete.RightNode != null)
                {
                    var leftNode = currentNodeForDelete.LeftNode;
                    previousNode.LeftNode = currentNodeForDelete.RightNode;
                    FindMinNode(currentNodeForDelete, leftNode);
                    return;
                }
            }

        }

        private void FindMinNode(Node<T> node, Node<T> left)
        {
            if (node.LeftNode == null)
            {
                node.LeftNode = left;
                return;
            }
            else
                FindMinNode(node.LeftNode, left);
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
