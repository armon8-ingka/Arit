using GenericTest.Interfaces;
using GenericTest.Models;
using GenericTest.Repositories;

public class Program
{
    private static async Task Main(string[] args)
    {
    var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services
        .AddScoped<ISubordinateInterface<SampleModel>>(x => new SampleRepository<SampleModel>())
        .AddScoped<ISubordinateInterface<SampleModel2>>(x => new SampleRepository<SampleModel2>());
        //.AddScoped<ISubordinateInterface<SampleModel2>>(x => new SampleRepository2<SampleModel2>());
    })
    .Build();

    var testRun = host.Services.GetRequiredService<ISubordinateInterface<SampleModel2>>();
    var testRun2 = host.Services.GetRequiredService<ISubordinateInterface<SampleModel>>();
    var sampleModel2 = new SampleModel2 { EmployeeId = Guid.NewGuid() };
    testRun.List(sampleModel2);
    testRun.ShowMessage(sampleModel2);
    testRun2.List(new SampleModel { Id = Guid.NewGuid() });  
    testRun2.ShowMessage(new SampleModel { Id = Guid.NewGuid() });
    }
}