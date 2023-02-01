using DataStructures;
using System.Xml.Linq;

Hello();
void Hello()
{
    MyLinkedList<int> ints= new MyLinkedList<int>();
    
    ints.Add(1);
    ints.Add(2);
    ints.Add(3);
    ints.Add(4);
    ints.Add(5);
    ints.Add(6);
    foreach(var node in ints)
        Console.WriteLine(node);
    Console.WriteLine();



    ints.Reverse();
    foreach (var node in ints)
        Console.WriteLine(node);
    Console.WriteLine();
    Console.WriteLine(ints.Count);




    Console.ReadKey();


}
