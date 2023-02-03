using DataStructures;
using DoubleLinkedList;


DoubleLinkedList();

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
