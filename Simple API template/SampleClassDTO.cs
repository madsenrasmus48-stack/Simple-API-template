using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_API_template;

public class SampleClassDTO
{
    public string Name {  get; set; }
    public int Age { get; set; }

    public SampleClassDTO(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
