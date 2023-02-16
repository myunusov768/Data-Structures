

namespace MyTree
{
    public sealed class Node
    {
        public int Value { get ; set ; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public Node(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static bool operator >=(Node left, Node right)
        {
            if (left == null)
                return false;
            if (right == null)
                return false;
            if (left.Value < right.Value)
                return false;
            return true;
        }
        public static bool operator <=(Node left, Node right)
        {
            if(left == null)
                return false;
            if(right == null)
                return false;
            if (left.Value <= right.Value)
                return true;
            return false;
        }
        public static bool operator <(Node left, Node right)
        {
            if (left == null)
                return false;
            if (right == null)
                return false;
            if (left.Value < right.Value)
                return false;
            return true;
        }
        public static bool operator >(Node left, Node right)
        {
            if (left == null)
                return false;
            if (right == null)
                return false;
            if (left.Value > right.Value)
                return true;
            return false;
        }
    }

    public sealed class MyBinaryTree
    {
        public int Count { get; private set; }
        public Node Root { get; private set; }

        //Создать новый ветвь дерево
        public void Insert(int value)
        {
            var _newNode = new Node(value);
            if (Root is null)
            {
                
                Root = _newNode;
                Count++;
                return;
            }
            Insert(Root, _newNode);
        }

        private void Insert(Node node, Node newNode)
        {
            if (newNode <= node)
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
            
            if (newNode > node)
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
        public List<int> PreOrder()
        {
            if(Root == null)
                return new List<int>();
            return PreOrder(Root);
        }
        private List<int> PreOrder(Node startNode)
        {
            var list = new List<int>();
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
        public List<int> PostOrder()
        {
            if (Root == null)
                return new List<int>();
            return PostOrder(Root);
        }
        private List<int> PostOrder(Node startNode)
        {
            var list = new List<int>();
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
        public List<int> InOrder()
        {
            if (Root == null)
                return new List<int>();
            return InOrder(Root);
        }
        private List<int> InOrder(Node startNode)
        {
            var list = new List<int>();
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
