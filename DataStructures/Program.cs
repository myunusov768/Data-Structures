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

    /*
    import java.util.NoSuchElementException;

// Hunter Schafer, CSE 143
// A LinkedList object represents an ordered list of linked nodes.
public class LinkedList<E> extends AbstractList<E> implements Queue<E> {
    private ListNode front;

// Constructs an empty list.
public LinkedList()
{
    front = null;
}

// Adds a value at a given index.
// pre: 0 <= index <= size
// Throws a NullPointerException if index > size.
public boolean add(int index, E value)
{
    if (index == 0)
    {
        front = new ListNode(value, front);
    }
    else
    {
        ListNode current = front;
        for (int i = 0; i < index - 1; i++)
        {
            current = current.next;
        }
        ListNode temp = new ListNode(value, current.next);
        current.next = temp;
        // also ok: current.next = new ListNode(value, current.next);
    }
    return true;
}

// Sets the given index to store the given value.
// pre: 0 <= index < size, throws ArrayIndexOutOfBoundsException otherwise
public void set(int index, E value)
{
    if (index < 0 || index >= size())
    {
        throw new ArrayIndexOutOfBoundsException();
    }
    ListNode current = front;
    for (int i = 0; i < index; i++)
    {
        current = current.next;
    }
    current.data = value;
}

// Returns the value at a given index
// pre: 0 <= index < number of nodes; front != null
// throws NullPointerException if index > size.
public E get(int index)
{
    ListNode current = front;
    for (int i = 0; i < index; i++)
    {
        current = current.next;
    }
    return current.data;
}

// Removes the value at the given index.
// Pre: 0 <= index < size
// Throws a NullPointerException if index > size.
public E remove(int index)
{
    if (index == 0)
    {
        E element = front.data;
        front = front.next;
        return element;
    }
    else
    {
        ListNode current = front;
        for (int i = 0; i < index - 1; i++)
        {
            current = current.next;
        }
        E element = current.next.data;
        current.next = current.next.next;
        return element;
    }
}

// Removes the given value if it is contained in this list
// Pre: value != null
// Throws a NullPointerException if index > size.
public boolean remove(E value)
{
    if (front == null)
    {
        return false;
    }
    if (front.data.equals(value))
    {
        front = front.next;
        return true;
    }
    else
    {
        ListNode current = front;
        while (current.next != null)
        {
            if (current.next.data.equals(value))
            {
                current.next = current.next.next;
                return true;
            }
            current = current.next;
        }
        return false;
    }
}

// Removes and returns the element at the front of this list
// Throws a NoSuchElementException if this list is empty.
public E remove()
{
    if (isEmpty())
    {
        throw new NoSuchElementException();
    }
    return remove(0);
}

// Returns the element on the front of this list.
// Throws a NoSuchElementException if the list is empty.
public E peek()
{
    if (isEmpty())
    {
        throw new NoSuchElementException();
    }
    return get(0);
}

// Returns the index of the first occurrence of the given value in the list,
// or -1 if the value is not found in the list.
public int indexOf(E value)
{
    int index = 0;
    ListNode current = front;
    while (current != null)
    {
        if (current.data.equals(value))
        {
            return index;
        }
        index++;
        current = current.next;
    }
    return -1;
}

// Returns the size of this list (inefficient -- could use a size field).
public int size()
{
    ListNode current = front;
    int count = 0;
    while (current != null)
    {
        current = current.next;
        count++;
    }
    return count;
}

// Returns a comma-separated String representation of this list.
public String toString()
{
    if (front == null)
    {
        return "[]";
    }
    else
    {
        String result = "[" + front.data;
        ListNode current = front.next;
        while (current != null)
        {
            result += ", " + current.data;
            current = current.next;
        }
        result += "]";
        return result;
    }
}

// A ListNode represents a single node in a linked list. It stores an
// integer
// value and a link to the next node.
private class ListNode
{
    public E data;
    public ListNode next;

    // Creates a ListNode with the specified integer data and next node.
    public ListNode(E data, ListNode next)
    {
        this.data = data;
        this.next = next;
    }
}
}

    */
}
