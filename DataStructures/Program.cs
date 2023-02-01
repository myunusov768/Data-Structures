using DataStructures;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

Hello();
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
