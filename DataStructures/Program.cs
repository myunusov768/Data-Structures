using DataStructures;
using DoubleLinkedList;
using MyHashTable;
using MyStackList;
using MyQueueList;
using MyQueue;
using MyTree;
using Graph;

try
{

    MyGraph();

    //MyTree();
    //Console.WriteLine(new String('-',20));
    //MyTree1();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void MyGraph()
{
    MyGraph graph = new MyGraph();
    graph.AddVertex(1);
    graph.AddVertex(2);
    graph.AddVertex(3);
    graph.AddVertex(4);
    graph.AddVertex(5);
    graph.AddVertex(6);
    graph.AddVertex(7);

    var v1 = graph.GetVertex(1);
    var v2 = graph.GetVertex(2);
    var v3 = graph.GetVertex(3);
    var v4 = graph.GetVertex(4);
    var v5 = graph.GetVertex(5);
    var v6 = graph.GetVertex(6);
    var v7 = graph.GetVertex(7);

    graph.AddEdge(v1,v2);
    graph.AddEdge(v1,v3);
    graph.AddEdge(v2,v5);
    graph.AddEdge(v2,v6);
    graph.AddEdge(v5,v6);
    graph.AddEdge(v3,v4);

    var matrix = graph.GetMatrix();

    for (int i = 0; i < graph.Vertices.Count; i++)
    {
        for (int j = 0; j < graph.Vertices.Count; j++)
        {
            Console.Write($"| {matrix[i, j]} |");
        }
        Console.WriteLine();
    }



}

void MyTree1()
{
    MyTreeGeneric<int> myTreeGeneric = new MyTreeGeneric<int>();
    myTreeGeneric.Insert(5);
    myTreeGeneric.Insert(3);
    myTreeGeneric.Insert(7);
    myTreeGeneric.Insert(1);
    myTreeGeneric.Insert(2);
    myTreeGeneric.Insert(8);
    myTreeGeneric.Insert(6);
    myTreeGeneric.Insert(9);
    myTreeGeneric.Insert(10);
    myTreeGeneric.Insert(4);

    var prelist = myTreeGeneric.PreOrder();
    foreach (var item in prelist)
    {
        Console.Write(item + ", ");
    }
    Console.ReadLine();

    var postlist = myTreeGeneric.PostOrder();
    foreach (var item in postlist)
    {
        Console.Write(item.ToString() + ", ");
    }
    Console.ReadLine();

    var inlist = myTreeGeneric.InOrder();
    foreach (var item in inlist)
    {
        Console.Write(item.ToString() + ", ");
    }
    Console.ReadLine();

}
void MyTree()
{
    MyBinaryTree integerTree = new MyBinaryTree();
    integerTree.Insert(5);
    integerTree.Insert(3);
    integerTree.Insert(7);
    integerTree.Insert(1);
    integerTree.Insert(2);
    integerTree.Insert(8);
    integerTree.Insert(6);
    integerTree.Insert(9);
    integerTree.Insert(10);
    integerTree.Insert(4);

    var prelist = integerTree.PreOrder();
    foreach (var item in prelist)
    {
        Console.Write(item + ", ");
    }
    Console.ReadLine();

    var postlist = integerTree.PostOrder();
    foreach (var item in postlist)
    {
        Console.Write(item.ToString() + ", ");
    }
    Console.ReadLine();

    var inlist = integerTree.InOrder();
    foreach (var item in inlist)
    {
        Console.Write(item.ToString() + ", ");
    }
    Console.ReadLine();


}

void MyQueue()
{
    MyQueue<string> strings = new MyQueue<string>();

    strings.Enqueue("Salom1");
    strings.Enqueue("Salom2");
    strings.Enqueue("Salom3");
    strings.Enqueue("Salom4");
    strings.Enqueue("Salom5");

    foreach (var item in strings)
        Console.WriteLine(item);

    Console.WriteLine("---------------");

    strings.Dequeue();
    foreach (var item in strings)
        Console.WriteLine(item);
    Console.WriteLine("---------------");

}
void MyQueueList()
{
    MyQueueList<string> strings= new MyQueueList<string>();

    strings.Enqueue("Salom1");
    
    foreach (var item in strings)
        Console.WriteLine(item);
    Console.WriteLine("---------------");
    string[] copy =  strings.ToArray();
    foreach (var item in copy)
        Console.WriteLine(item);

    Console.WriteLine("---------------");
    string[] array = strings.SplitListToArrayFromIndex(3);
    
    


}

void StackList()
{
    MyStackList<string> myStackList= new MyStackList<string>();
    Console.WriteLine(myStackList.IsFull());
    Console.WriteLine(myStackList.IsEmpty());


    myStackList.Push("Muhammad");
    myStackList.Push("Boyazid");
    myStackList.Push("Muboraksho");
    myStackList.Push("Suhrob");
    myStackList.Push("Tolibjon");
    
    Queue<string> queue = new Queue<string>();
    

    foreach (var item in myStackList)
        Console.WriteLine(item);
    Console.WriteLine(new String('-', 15));

    Console.WriteLine(myStackList.IsFull());
    Console.WriteLine(myStackList.IsEmpty());

    myStackList.Pop();

    foreach (var item in myStackList)
        Console.WriteLine(item);
    Console.WriteLine(new String('-', 15));



}



void HashTable()
{
    MyHashTable<int, string> myHashTable = new MyHashTable<int, string>(15);

    var key = "Muhammad";


    myHashTable["Muhammad1"] = 1;
    myHashTable["Muhammad2"] = 2;
    myHashTable["Muhammad3"] = 3;
    myHashTable["Muhammad4"] = 4;
    myHashTable["Muhammad5"] = 5;
    myHashTable["Muhammad6"] = 6;
    myHashTable["Muhammad7"] = 7;
    myHashTable["Muhammad8"] = 8;
    myHashTable["Muhammad9"] = 9;
    myHashTable["Muhammad10"] = 10;
    myHashTable["Muhammad11"] = 11;
    myHashTable["Muhammad12"] = 12;
    myHashTable["Muhammad13"] = 13;
    myHashTable["Muhammad14"] = 14;
    myHashTable["Muhammad15"] = 15;
    myHashTable["Muhammad16"] = 16;

    foreach (var item in myHashTable)
        Console.WriteLine(item?.Value ?? 0);
    Console.WriteLine(new String('-', 15));
    myHashTable.Reverse();
    foreach (var item in myHashTable)
        Console.WriteLine(item?.Value ?? 0);
    Console.WriteLine(new String('-', 15));
}







void DoubleLinkedList()
{
    DoubleLinkedList<int> ints= new DoubleLinkedList<int>();

    
    ints.Add(1);
    ints.Add(2);
    ints.Add(3);
    ints.Add(4);
    ints.Add(5);

    foreach (var item in ints)
        Console.WriteLine($"Previous: {item.Previous?.Value ?? 0} <- item: {item.Value} -> Next: {item.Next?.Value ?? 0}");
    Console.WriteLine("--------");



    ints.Reverse();

    Console.WriteLine("--------");

    foreach (var item in ints)
        Console.WriteLine($"Previous: {item.Previous?.Value ?? 0} <- item: {item.Value} -> Next: {item.Next?.Value ?? 0}");


    
}



void Hello()
{
    LinkedList<string> list = new LinkedList<string>();
    MyLinkedList2<int> ints= new MyLinkedList2<int>();
    
    ints.Add(1);
    ints.Add(2);
    ints.Add(3);
    ints.Add(4);
    ints.Add(5);
    ints.Add(6);
    ints.Delete(1);
    ints.AddInHead(1);
    ints.AddInTail(7);
    ints.AddInMiddle(0);
    ints.DeleteTial();
    foreach (var node in ints)
        Console.WriteLine(node);
    Console.WriteLine();

    ints.Reverse();

    foreach (var node in ints)
        Console.WriteLine(node);
    Console.WriteLine();
    bool b = ints.Contains(5);
    Console.WriteLine(b);




    Console.ReadKey();

}
