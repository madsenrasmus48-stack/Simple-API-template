using Simple_API_template.Dataservices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_API_template;

public class SampleClass : ISampleClass
{


    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }


    public SampleClass(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

}
