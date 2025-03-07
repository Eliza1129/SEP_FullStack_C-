using Generic_Repository_Pattern.Repository;

namespace Generic_Repository_Pattern;
using System;
using System.Collections.Generic;

public class GenericRepository<T>: IRepository<T> where T:Entity
{
    private readonly List<T> _dataStore;

    public GenericRepository()
    {
        _dataStore = new List<T>();
    }
    
    //add an entity
    public void Add(T item)
    {
        if (item == null)
            throw new ArgumentException(nameof(item));
        _dataStore.Add(item);
    }
    
    //remove an entity
    public void Remove(T item)
    {
        if (item == null)
            throw new ArgumentException(nameof(item));
        
        _dataStore.Remove(item);
    }
    
    //save changes
    public void Save()
    {
        Console.WriteLine("GenericRepository save changes");
    }
    
    //return all items
    public IEnumerable<T> GetAll()
    {
        return _dataStore;
    }
    
    //Find an entity by its ID
    public T GetById(int id)
    {
        return _dataStore.FirstOrDefault(e => e.Id == id);
    }
}

