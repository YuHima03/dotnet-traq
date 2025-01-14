# dotnet-traq

Dotnet client library for the traQ API.

## How to Use

### Use in Generic Host

An extension method for the `IServiceCollection` type can be used.

In this case, a singleton instance of the `ITraqApiClient` type is provided by an `IServiceProvider` instance.

```cs
var builder = Host.CreateApplicationBuilder();

builder.Services
    .AddTraqApiClient(conf => {
        conf.SetBaseAddress("http://****.com/api")
            .UseBearerAuthentication("sample_access_token")
    });

builder.Build().Run();
```
