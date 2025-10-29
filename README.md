# dotnet-traq

.NET client library for the traQ API.

The source code is generated from the [OpenAPI Spec for the traQ API](https://github.com/traPtitech/traQ/blob/master/docs/v3-api.yaml) by [Microsoft Kiota](https://github.com/microsoft/kiota).

## How to Use

### Use in Generic Host

An extension method for the `IServiceCollection` type can be used.

In the sample code below, an instance of the `TraqApiClient` class configured by environment variables (`TRAQ_BASE_ADDRESS` and `TRAQ_ACCESS_TOKEN`) is added to the service collection.

```cs
var host = Host.CreateDefaultApplication(args)
    .ConfigureServices((ctx, services) =>
    {
        services.AddTraqApiClient(options =>
        {
            var conf = ctx.Configuration;
            options.BaseAddress = conf["TRAQ_BASE_ADDRESS"];
            options.BearerAuthToken = conf["TRAQ_ACCESS_TOKEN"];
        });
    })
    .Build();

host.Run();
```

You can also separate configurator from the `AddTraqApiClient` method by using parameterless method.
In the following code, the added `TraqApiClient` automatically use configured `TraqApiClientOptions`.

```cs
var host = Host.CreateDefaultApplication(args)
    .ConfigureServices((ctx, services) =>
    {
        services.Configure<TraqApiClientOptions>(ctx.Configuration);
        services.AddTraqApiClient();
    })
    .Build();

host.Run();
```

### Create API Client Manually

The `CreateFromOptions` method in the `TraqApiClientHelper` class is useful to create a new instance of the `TraqApiClient` class with specified options.

```cs
TraqApiClientOptions options = new()
{
    BaseAddress = "Base address of the traQ API",
    BearerAuthToken = "Bearer authentication token"
}
var client = TraqApiClientHelper.CreateFromOptions(options);
```

The `TraqApiClient` class implements `Microsoft.Kiota.Abstractions.BaseRequestBuilder` so that you can manually manage methods to access the traQ API.

For more information, please check [Kiota Official Documentation](https://learn.microsoft.com/en-us/openapi/kiota/overview).

## Source Generation

[Docker](https://www.docker.com) and [Task](https://taskfile.dev) are required for source generation.

To generate API client for certain version of traQ, set it to the `TRAQ_TAG_NAME` variable and run `task`, `task gen` or `task generate-client`.

The following command generates API client for traQ v3.26.0.

```bash
TRAQ_TAG_NAME="v3.26.0" task
```
