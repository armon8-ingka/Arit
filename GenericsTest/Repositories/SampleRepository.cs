using GenericTest.Interfaces;
using GenericTest.Models;

namespace GenericTest.Repositories;

public class SampleRepository<T> : ISubordinateInterface<T>
where T : class
{
  public IEnumerable<T> List(T t)
  {
    var obj = new object();

    if (typeof(T) == typeof(SampleModel))
    {
      var sampleModel = (SampleModel)Convert.ChangeType(t, typeof(SampleModel));
      obj = sampleModel.Id;
      Console.WriteLine($"Inside SampleRepository()- Id is {obj}");
    }
    else
    {
      var sampleModel2 = (SampleModel2)Convert.ChangeType(t, typeof(SampleModel2));
      obj = sampleModel2.EmployeeId;
      Console.WriteLine($"Inside SampleRepository()- EmployeeId is {obj}");
    }
    
    return new List<T>();
  }
  public void ShowMessage(T t)
  {
    Console.WriteLine($"Inside SampleRepository() -> ShowMessage({typeof(T)})");
  }
}
