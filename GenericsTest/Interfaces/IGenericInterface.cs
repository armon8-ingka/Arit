namespace GenericTest.Interfaces;

public interface IGenericInterface<T> where T : class
{
    IEnumerable<T> List(T t);
}
