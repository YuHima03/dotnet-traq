# dotnet-traq

Dotnet client library for the traQ API.

## How to Use

### Use in Generic Host

An extension method for the `IServiceCollection` type can be used.

In this case, a singleton instance of the `ITraqApiClient` type is provided by an `IServiceProvider` instance.

```cs
var host = Host.CreateDefaultApplication()
    .ConfigureServices(services =>
    {
        services.AddTraqApiClient(option =>
        {
            option.BaseAddress = Environment.GetEnvironmentVariable("TRAQ_BASE_ADDRESS");
            option.BearerAuthToken = Environment.GetEnvironmentVariable("TRAQ_ACCESS_TOKEN");
        });
    })
    .Build();

host.Run();
```
