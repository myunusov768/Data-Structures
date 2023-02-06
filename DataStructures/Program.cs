using DataStructures;
using DoubleLinkedList;
using MyHashTable;
using MyStackList;

try
{

    StackList();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
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


    foreach(var item in myStackList)
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
