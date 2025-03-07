namespace Generic_List;
using System;
using System.Collections.Generic;
public class MyList<T>
{
    private List<T> elements;

    public MyList()
    {
        elements = new List<T>();
    }
    public void Add(T element)
    {
        elements.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        T removedElement = elements[index];
        elements.RemoveAt(index);
        return removedElement;
    }

    public bool Contains(T element)
    {
        return elements.Contains(element);
    }

    public void Clear()
    {
        elements.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        elements.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        elements.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        return elements[index];
    }
    
    //Helper function
    public void PrintAll()
    {
        foreach (var item in elements)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    
}