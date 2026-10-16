using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Hosting;
using Simple_API_template;
using Simple_API_template.Dataservices;

namespace Simple_API_template.Repositories;



public class SampleClassRepository : ISampleClassRepository
{
    private static int _nextid;
    public List<SampleClass> Data { get; private set; }

    public SampleClassRepository()
    {
        Data = new List<SampleClass>();
    }




    public IEnumerable<SampleClass> GetAll()
    {
        return Data;
    }

    public SampleClass GetById(int id)
    {
        SampleClass? result = Data.FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            throw new ArgumentException("id does not correspond with an item");
        }
        return (SampleClass)result;
    }

    public SampleClass Create(string name, int age)
    {
        int id;
        id = GetNextId();
        SampleClass newObject = new SampleClass(id, name, age);
        Data.Add(newObject);
        return newObject;
    }

    public SampleClass Delete(int id)
    {
        SampleClass result = GetById(id);
        Data.Remove(result);
        return result;
    }

    public SampleClass Update(int id, string name, int age)
    {
        SampleClass oldObject = GetById(id);
        SampleClass newObject = new SampleClass(id, name, age);
        Data[id - 1] = newObject;
        return newObject;
    }

    private int GetNextId()
    {
        _nextid++;
        return _nextid;
    }
}
