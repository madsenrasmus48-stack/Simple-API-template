using System;
using System.Collections.Generic;
using System.Text;
using Simple_API_template;

namespace Simple_API_template.Repositories;

public class SampleClassRepository
{
    public SampleClassRepository()
    {
        Data = new List<SampleClass>();
    }

    public List<SampleClass> Data { get; private set; }
}
