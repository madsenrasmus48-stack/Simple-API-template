namespace Simple_API_template.Dataservices;

public interface ISampleClassRepository
{
    List<SampleClass> Data { get; }

    SampleClass Create(string name, int age);
    SampleClass Delete(int id);
    IEnumerable<SampleClass> GetAll();
    SampleClass GetById(int id);
    SampleClass Update(int id, string name, int age);
}