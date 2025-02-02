# Traq.Api.WebhookApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeWebhookIcon**](WebhookApi.md#changewebhookicon) | **PUT** /webhooks/{webhookId}/icon | Webhookのアイコンを変更 |
| [**CreateWebhook**](WebhookApi.md#createwebhook) | **POST** /webhooks | Webhookを新規作成 |
| [**DeleteWebhook**](WebhookApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Webhookを削除 |
| [**EditWebhook**](WebhookApi.md#editwebhook) | **PATCH** /webhooks/{webhookId} | Webhook情報を変更 |
| [**GetWebhook**](WebhookApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Webhook情報を取得 |
| [**GetWebhookIcon**](WebhookApi.md#getwebhookicon) | **GET** /webhooks/{webhookId}/icon | Webhookのアイコンを取得 |
| [**GetWebhookMessages**](WebhookApi.md#getwebhookmessages) | **GET** /webhooks/{webhookId}/messages | Webhookの投稿メッセージのリストを取得 |
| [**GetWebhooks**](WebhookApi.md#getwebhooks) | **GET** /webhooks | Webhook情報のリストを取得します |
| [**PostWebhook**](WebhookApi.md#postwebhook) | **POST** /webhooks/{webhookId} | Webhookを送信 |

<a id="changewebhookicon"></a>
# **ChangeWebhookIcon**
> void ChangeWebhookIcon (Guid webhookId, FileParameter file)

Webhookのアイコンを変更

指定したWebhookのアイコン画像を変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ChangeWebhookIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | アイコン画像(2MBまでのpng, jpeg, gif)

            try
            {
                // Webhookのアイコンを変更
                apiInstance.ChangeWebhookIcon(webhookId, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.ChangeWebhookIcon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeWebhookIconWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhookのアイコンを変更
    apiInstance.ChangeWebhookIconWithHttpInfo(webhookId, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.ChangeWebhookIconWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
| **file** | **FileParameter****FileParameter** | アイコン画像(2MBまでのpng, jpeg, gif) |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content 変更されました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createwebhook"></a>
# **CreateWebhook**
> Webhook CreateWebhook (PostWebhookRequest? postWebhookRequest = null)

Webhookを新規作成

Webhookを新規作成します。 `secret`が空文字の場合、insecureウェブフックが作成されます。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var postWebhookRequest = new PostWebhookRequest?(); // PostWebhookRequest? |  (optional) 

            try
            {
                // Webhookを新規作成
                Webhook result = apiInstance.CreateWebhook(postWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.CreateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhookを新規作成
    ApiResponse<Webhook> response = apiInstance.CreateWebhookWithHttpInfo(postWebhookRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.CreateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postWebhookRequest** | [**PostWebhookRequest?**](PostWebhookRequest?.md) |  | [optional]  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (Guid webhookId)

Webhookを削除

指定したWebhookを削除します。 Webhookによって投稿されたメッセージは削除されません。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID

            try
            {
                // Webhookを削除
                apiInstance.DeleteWebhook(webhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.DeleteWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhookを削除
    apiInstance.DeleteWebhookWithHttpInfo(webhookId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.DeleteWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content 削除されました。 |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editwebhook"></a>
# **EditWebhook**
> void EditWebhook (Guid webhookId, PatchWebhookRequest? patchWebhookRequest = null)

Webhook情報を変更

指定したWebhookの情報を変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class EditWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID
            var patchWebhookRequest = new PatchWebhookRequest?(); // PatchWebhookRequest? |  (optional) 

            try
            {
                // Webhook情報を変更
                apiInstance.EditWebhook(webhookId, patchWebhookRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.EditWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhook情報を変更
    apiInstance.EditWebhookWithHttpInfo(webhookId, patchWebhookRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.EditWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
| **patchWebhookRequest** | [**PatchWebhookRequest?**](PatchWebhookRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content 編集できました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (Guid webhookId)

Webhook情報を取得

指定したWebhookの詳細を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID

            try
            {
                // Webhook情報を取得
                Webhook result = apiInstance.GetWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhook情報を取得
    ApiResponse<Webhook> response = apiInstance.GetWebhookWithHttpInfo(webhookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhookicon"></a>
# **GetWebhookIcon**
> FileParameter GetWebhookIcon (Guid webhookId)

Webhookのアイコンを取得

指定したWebhookのアイコン画像を取得します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetWebhookIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID

            try
            {
                // Webhookのアイコンを取得
                FileParameter result = apiInstance.GetWebhookIcon(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhookIcon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookIconWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhookのアイコンを取得
    ApiResponse<FileParameter> response = apiInstance.GetWebhookIconWithHttpInfo(webhookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetWebhookIconWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/jpeg, image/gif, image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhookmessages"></a>
# **GetWebhookMessages**
> List&lt;Message&gt; GetWebhookMessages (Guid webhookId, int? limit = null, int? offset = null, DateTimeOffset? since = null, DateTimeOffset? until = null, bool? inclusive = null, string? order = null)

Webhookの投稿メッセージのリストを取得

指定されたWebhookが投稿したメッセージのリストを返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetWebhookMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID
            var limit = 50;  // int? | 取得する件数 (optional) 
            var offset = 150;  // int? | 取得するオフセット (optional)  (default to 0)
            var since = 2016-10-12T11:00:00.000000Z;  // DateTimeOffset? | 取得する時間範囲の開始日時 (optional)  (default to "0000-01-01T00:00Z")
            var until = 2016-10-12T11:00:00.0000000Z;  // DateTimeOffset? | 取得する時間範囲の終了日時 (optional) 
            var inclusive = false;  // bool? | 範囲の端を含めるかどうか (optional)  (default to false)
            var order = "asc";  // string? | 昇順か降順か (optional)  (default to desc)

            try
            {
                // Webhookの投稿メッセージのリストを取得
                List<Message> result = apiInstance.GetWebhookMessages(webhookId, limit, offset, since, until, inclusive, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhookMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhookの投稿メッセージのリストを取得
    ApiResponse<List<Message>> response = apiInstance.GetWebhookMessagesWithHttpInfo(webhookId, limit, offset, since, until, inclusive, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetWebhookMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
| **limit** | **int?** | 取得する件数 | [optional]  |
| **offset** | **int?** | 取得するオフセット | [optional] [default to 0] |
| **since** | **DateTimeOffset?** | 取得する時間範囲の開始日時 | [optional] [default to &quot;0000-01-01T00:00Z&quot;] |
| **until** | **DateTimeOffset?** | 取得する時間範囲の終了日時 | [optional]  |
| **inclusive** | **bool?** | 範囲の端を含めるかどうか | [optional] [default to false] |
| **order** | **string?** | 昇順か降順か | [optional] [default to desc] |

### Return type

[**List&lt;Message&gt;**](Message.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-TRAQ-MORE -  <br>  |
| **400** | Bad Request |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhooks"></a>
# **GetWebhooks**
> List&lt;Webhook&gt; GetWebhooks (bool? all = null)

Webhook情報のリストを取得します

Webhookのリストを取得します。 allがtrueで無い場合は、自分がオーナーのWebhookのリストを返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var all = false;  // bool? | 全てのWebhookを取得します。権限が必要です。 (optional)  (default to false)

            try
            {
                // Webhook情報のリストを取得します
                List<Webhook> result = apiInstance.GetWebhooks(all);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhook情報のリストを取得します
    ApiResponse<List<Webhook>> response = apiInstance.GetWebhooksWithHttpInfo(all);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **all** | **bool?** | 全てのWebhookを取得します。権限が必要です。 | [optional] [default to false] |

### Return type

[**List&lt;Webhook&gt;**](Webhook.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postwebhook"></a>
# **PostWebhook**
> void PostWebhook (Guid webhookId, string? xTRAQSignature = null, string? xTRAQChannelId = null, int? embed = null, string? body = null)

Webhookを送信

Webhookにメッセージを投稿します。 secureなウェブフックに対しては`X-TRAQ-Signature`ヘッダーが必須です。 アーカイブされているチャンネルには投稿できません。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class PostWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebhookApi(httpClient, config, httpClientHandler);
            var webhookId = "webhookId_example";  // Guid | WebhookUUID
            var xTRAQSignature = "xTRAQSignature_example";  // string? | リクエストボディシグネチャ(Secretが設定されている場合は必須) (optional) 
            var xTRAQChannelId = "xTRAQChannelId_example";  // string? | 投稿先のチャンネルID(変更する場合) (optional) 
            var embed = 0;  // int? | メンション・チャンネルリンクを自動埋め込みする場合に1を指定する (optional)  (default to 0)
            var body = "body_example";  // string? |  (optional) 

            try
            {
                // Webhookを送信
                apiInstance.PostWebhook(webhookId, xTRAQSignature, xTRAQChannelId, embed, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.PostWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Webhookを送信
    apiInstance.PostWebhookWithHttpInfo(webhookId, xTRAQSignature, xTRAQChannelId, embed, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.PostWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
| **xTRAQSignature** | **string?** | リクエストボディシグネチャ(Secretが設定されている場合は必須) | [optional]  |
| **xTRAQChannelId** | **string?** | 投稿先のチャンネルID(変更する場合) | [optional]  |
| **embed** | **int?** | メンション・チャンネルリンクを自動埋め込みする場合に1を指定する | [optional] [default to 0] |
| **body** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

