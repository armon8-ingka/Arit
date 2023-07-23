using GenericTest.Interfaces;
using GenericTest.Models;
using GenericTest.Repositories;

namespace GenericTest.Repositories;

public class SampleRepository2<T> //: ISubordinateInterface<T>
//where T : class
{
    public IEnumerable<T> List(T t)
    {
       Console.WriteLine("Inside SampleRepository2()");   
       return new List<T>();
    }

    public void ShowMessage(T t)
    {
        Console.WriteLine($"Inside SampleRepository2() -> ShowMessage({typeof(T)})"); 
    }
}
