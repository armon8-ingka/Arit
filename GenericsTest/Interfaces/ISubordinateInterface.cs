using GenericTest.Models;

namespace GenericTest.Interfaces;

public interface ISubordinateInterface<T> : IGenericInterface<T> 
where T : class
{
        void ShowMessage(T t);
}
