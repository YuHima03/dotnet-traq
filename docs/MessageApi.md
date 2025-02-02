# Traq.Api.MessageApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMessageStamp**](MessageApi.md#addmessagestamp) | **POST** /messages/{messageId}/stamps/{stampId} | スタンプを押す |
| [**CreatePin**](MessageApi.md#createpin) | **POST** /messages/{messageId}/pin | ピン留めする |
| [**DeleteMessage**](MessageApi.md#deletemessage) | **DELETE** /messages/{messageId} | メッセージを削除 |
| [**EditMessage**](MessageApi.md#editmessage) | **PUT** /messages/{messageId} | メッセージを編集 |
| [**GetDirectMessages**](MessageApi.md#getdirectmessages) | **GET** /users/{userId}/messages | ダイレクトメッセージのリストを取得 |
| [**GetMessage**](MessageApi.md#getmessage) | **GET** /messages/{messageId} | メッセージを取得 |
| [**GetMessageClips**](MessageApi.md#getmessageclips) | **GET** /messages/{messageId}/clips | 自分のクリップを取得 |
| [**GetMessageStamps**](MessageApi.md#getmessagestamps) | **GET** /messages/{messageId}/stamps | メッセージのスタンプリストを取得 |
| [**GetMessages**](MessageApi.md#getmessages) | **GET** /channels/{channelId}/messages | チャンネルメッセージのリストを取得 |
| [**GetPin**](MessageApi.md#getpin) | **GET** /messages/{messageId}/pin | ピン留めを取得 |
| [**PostDirectMessage**](MessageApi.md#postdirectmessage) | **POST** /users/{userId}/messages | ダイレクトメッセージを送信 |
| [**PostMessage**](MessageApi.md#postmessage) | **POST** /channels/{channelId}/messages | チャンネルにメッセージを投稿 |
| [**RemoveMessageStamp**](MessageApi.md#removemessagestamp) | **DELETE** /messages/{messageId}/stamps/{stampId} | スタンプを消す |
| [**RemovePin**](MessageApi.md#removepin) | **DELETE** /messages/{messageId}/pin | ピン留めを外す |
| [**SearchMessages**](MessageApi.md#searchmessages) | **GET** /messages | メッセージを検索 |

<a id="addmessagestamp"></a>
# **AddMessageStamp**
> void AddMessageStamp (Guid messageId, Guid stampId, PostMessageStampRequest? postMessageStampRequest = null)

スタンプを押す

指定したメッセージに指定したスタンプを押します。

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
    public class AddMessageStampExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID
            var stampId = "stampId_example";  // Guid | スタンプUUID
            var postMessageStampRequest = new PostMessageStampRequest?(); // PostMessageStampRequest? |  (optional) 

            try
            {
                // スタンプを押す
                apiInstance.AddMessageStamp(messageId, stampId, postMessageStampRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.AddMessageStamp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMessageStampWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプを押す
    apiInstance.AddMessageStampWithHttpInfo(messageId, stampId, postMessageStampRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.AddMessageStampWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |
| **stampId** | **Guid** | スタンプUUID |  |
| **postMessageStampRequest** | [**PostMessageStampRequest?**](PostMessageStampRequest?.md) |  | [optional]  |

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
| **204** | No Content スタンプを押すことができました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found メッセージ、またはスタンプが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpin"></a>
# **CreatePin**
> MessagePin CreatePin (Guid messageId)

ピン留めする

指定したメッセージをピン留めします。 アーカイブされているチャンネルのメッセージ・存在しないメッセージ・チャンネル当たりの上限数を超えたメッセージのピン留めはできません。

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
    public class CreatePinExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // ピン留めする
                MessagePin result = apiInstance.CreatePin(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.CreatePin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePinWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ピン留めする
    ApiResponse<MessagePin> response = apiInstance.CreatePinWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.CreatePinWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**MessagePin**](MessagePin.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created 指定したメッセージがピン留めされました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found メッセージが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemessage"></a>
# **DeleteMessage**
> void DeleteMessage (Guid messageId)

メッセージを削除

指定したメッセージを削除します。 自身が投稿したメッセージと自身が管理権限を持つWebhookとBOTが投稿したメッセージのみ削除することができます。 アーカイブされているチャンネルのメッセージを編集することは出来ません。

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
    public class DeleteMessageExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // メッセージを削除
                apiInstance.DeleteMessage(messageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.DeleteMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージを削除
    apiInstance.DeleteMessageWithHttpInfo(messageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.DeleteMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

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
| **204** | No Content 正常に削除できました。 |  -  |
| **403** | Forbidden 指定されたメッセージを削除する権限がありません。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editmessage"></a>
# **EditMessage**
> void EditMessage (Guid messageId, PostMessageRequest? postMessageRequest = null)

メッセージを編集

指定したメッセージを編集します。 自身が投稿したメッセージのみ編集することができます。 アーカイブされているチャンネルのメッセージを編集することは出来ません。

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
    public class EditMessageExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID
            var postMessageRequest = new PostMessageRequest?(); // PostMessageRequest? |  (optional) 

            try
            {
                // メッセージを編集
                apiInstance.EditMessage(messageId, postMessageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.EditMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージを編集
    apiInstance.EditMessageWithHttpInfo(messageId, postMessageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.EditMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |
| **postMessageRequest** | [**PostMessageRequest?**](PostMessageRequest?.md) |  | [optional]  |

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
| **204** | No Content メッセージを編集できました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden 指定されたメッセージを編集する権限がありません。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdirectmessages"></a>
# **GetDirectMessages**
> List&lt;Message&gt; GetDirectMessages (Guid userId, int? limit = null, int? offset = null, DateTimeOffset? since = null, DateTimeOffset? until = null, bool? inclusive = null, string? order = null)

ダイレクトメッセージのリストを取得

指定したユーザーとのダイレクトメッセージのリストを取得します。

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
    public class GetDirectMessagesExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // Guid | ユーザーUUID
            var limit = 50;  // int? | 取得する件数 (optional) 
            var offset = 150;  // int? | 取得するオフセット (optional)  (default to 0)
            var since = 2016-10-12T11:00:00.000000Z;  // DateTimeOffset? | 取得する時間範囲の開始日時 (optional)  (default to "0000-01-01T00:00Z")
            var until = 2016-10-12T11:00:00.0000000Z;  // DateTimeOffset? | 取得する時間範囲の終了日時 (optional) 
            var inclusive = false;  // bool? | 範囲の端を含めるかどうか (optional)  (default to false)
            var order = "asc";  // string? | 昇順か降順か (optional)  (default to desc)

            try
            {
                // ダイレクトメッセージのリストを取得
                List<Message> result = apiInstance.GetDirectMessages(userId, limit, offset, since, until, inclusive, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.GetDirectMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDirectMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ダイレクトメッセージのリストを取得
    ApiResponse<List<Message>> response = apiInstance.GetDirectMessagesWithHttpInfo(userId, limit, offset, since, until, inclusive, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.GetDirectMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
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
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessage"></a>
# **GetMessage**
> Message GetMessage (Guid messageId)

メッセージを取得

指定したメッセージを取得します。

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
    public class GetMessageExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // メッセージを取得
                Message result = apiInstance.GetMessage(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.GetMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージを取得
    ApiResponse<Message> response = apiInstance.GetMessageWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.GetMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**Message**](Message.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessageclips"></a>
# **GetMessageClips**
> List&lt;MessageClip&gt; GetMessageClips (Guid messageId)

自分のクリップを取得

対象のメッセージの自分のクリップの一覧を返します。

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
    public class GetMessageClipsExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // 自分のクリップを取得
                List<MessageClip> result = apiInstance.GetMessageClips(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.GetMessageClips: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageClipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のクリップを取得
    ApiResponse<List<MessageClip>> response = apiInstance.GetMessageClipsWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.GetMessageClipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**List&lt;MessageClip&gt;**](MessageClip.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagestamps"></a>
# **GetMessageStamps**
> List&lt;MessageStamp&gt; GetMessageStamps (Guid messageId)

メッセージのスタンプリストを取得

指定したメッセージに押されているスタンプのリストを取得します。

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
    public class GetMessageStampsExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // メッセージのスタンプリストを取得
                List<MessageStamp> result = apiInstance.GetMessageStamps(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.GetMessageStamps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageStampsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージのスタンプリストを取得
    ApiResponse<List<MessageStamp>> response = apiInstance.GetMessageStampsWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.GetMessageStampsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**List&lt;MessageStamp&gt;**](MessageStamp.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessages"></a>
# **GetMessages**
> List&lt;Message&gt; GetMessages (Guid channelId, int? limit = null, int? offset = null, DateTimeOffset? since = null, DateTimeOffset? until = null, bool? inclusive = null, string? order = null)

チャンネルメッセージのリストを取得

指定したチャンネルのメッセージのリストを取得します。

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
    public class GetMessagesExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var channelId = "channelId_example";  // Guid | チャンネルUUID
            var limit = 50;  // int? | 取得する件数 (optional) 
            var offset = 150;  // int? | 取得するオフセット (optional)  (default to 0)
            var since = 2016-10-12T11:00:00.000000Z;  // DateTimeOffset? | 取得する時間範囲の開始日時 (optional)  (default to "0000-01-01T00:00Z")
            var until = 2016-10-12T11:00:00.0000000Z;  // DateTimeOffset? | 取得する時間範囲の終了日時 (optional) 
            var inclusive = false;  // bool? | 範囲の端を含めるかどうか (optional)  (default to false)
            var order = "asc";  // string? | 昇順か降順か (optional)  (default to desc)

            try
            {
                // チャンネルメッセージのリストを取得
                List<Message> result = apiInstance.GetMessages(channelId, limit, offset, since, until, inclusive, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.GetMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネルメッセージのリストを取得
    ApiResponse<List<Message>> response = apiInstance.GetMessagesWithHttpInfo(channelId, limit, offset, since, until, inclusive, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.GetMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
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
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpin"></a>
# **GetPin**
> MessagePin GetPin (Guid messageId)

ピン留めを取得

指定したメッセージのピン留め情報を取得します。

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
    public class GetPinExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // ピン留めを取得
                MessagePin result = apiInstance.GetPin(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.GetPin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPinWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ピン留めを取得
    ApiResponse<MessagePin> response = apiInstance.GetPinWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.GetPinWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**MessagePin**](MessagePin.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found 指定したメッセージ、またはピン留めが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postdirectmessage"></a>
# **PostDirectMessage**
> Message PostDirectMessage (Guid userId, PostMessageRequest? postMessageRequest = null)

ダイレクトメッセージを送信

指定したユーザーにダイレクトメッセージを送信します。

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
    public class PostDirectMessageExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // Guid | ユーザーUUID
            var postMessageRequest = new PostMessageRequest?(); // PostMessageRequest? |  (optional) 

            try
            {
                // ダイレクトメッセージを送信
                Message result = apiInstance.PostDirectMessage(userId, postMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.PostDirectMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostDirectMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ダイレクトメッセージを送信
    ApiResponse<Message> response = apiInstance.PostDirectMessageWithHttpInfo(userId, postMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.PostDirectMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
| **postMessageRequest** | [**PostMessageRequest?**](PostMessageRequest?.md) |  | [optional]  |

### Return type

[**Message**](Message.md)

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
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmessage"></a>
# **PostMessage**
> Message PostMessage (Guid channelId, PostMessageRequest? postMessageRequest = null)

チャンネルにメッセージを投稿

指定したチャンネルにメッセージを投稿します。 embedをtrueに指定すると、メッセージ埋め込みが自動で行われます。 アーカイブされているチャンネルに投稿することはできません。

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
    public class PostMessageExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var channelId = "channelId_example";  // Guid | チャンネルUUID
            var postMessageRequest = new PostMessageRequest?(); // PostMessageRequest? |  (optional) 

            try
            {
                // チャンネルにメッセージを投稿
                Message result = apiInstance.PostMessage(channelId, postMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.PostMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネルにメッセージを投稿
    ApiResponse<Message> response = apiInstance.PostMessageWithHttpInfo(channelId, postMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.PostMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **postMessageRequest** | [**PostMessageRequest?**](PostMessageRequest?.md) |  | [optional]  |

### Return type

[**Message**](Message.md)

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
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removemessagestamp"></a>
# **RemoveMessageStamp**
> void RemoveMessageStamp (Guid messageId, Guid stampId)

スタンプを消す

指定したメッセージから指定した自身が押したスタンプを削除します。

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
    public class RemoveMessageStampExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID
            var stampId = "stampId_example";  // Guid | スタンプUUID

            try
            {
                // スタンプを消す
                apiInstance.RemoveMessageStamp(messageId, stampId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.RemoveMessageStamp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMessageStampWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプを消す
    apiInstance.RemoveMessageStampWithHttpInfo(messageId, stampId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.RemoveMessageStampWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |
| **stampId** | **Guid** | スタンプUUID |  |

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
| **204** | No Content スタンプを消すことができました。 |  -  |
| **404** | Not Found メッセージ、またはスタンプが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removepin"></a>
# **RemovePin**
> void RemovePin (Guid messageId)

ピン留めを外す

指定したメッセージのピン留めを外します。

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
    public class RemovePinExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // ピン留めを外す
                apiInstance.RemovePin(messageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.RemovePin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemovePinWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ピン留めを外す
    apiInstance.RemovePinWithHttpInfo(messageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.RemovePinWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

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
| **204** | No Content 指定したメッセージのピン留めが外されました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found 指定したメッセージ、またはピン留めが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchmessages"></a>
# **SearchMessages**
> MessageSearchResult SearchMessages (string? word = null, DateTimeOffset? after = null, DateTimeOffset? before = null, Guid? varIn = null, List<Guid>? to = null, List<Guid>? from = null, Guid? citation = null, bool? bot = null, bool? hasURL = null, bool? hasAttachments = null, bool? hasImage = null, bool? hasVideo = null, bool? hasAudio = null, int? limit = null, int? offset = null, string? sort = null)

メッセージを検索

メッセージを検索します。

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
    public class SearchMessagesExample
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
            var apiInstance = new MessageApi(httpClient, config, httpClientHandler);
            var word = "phrase match" +(foo | bar) -baz;  // string? | 検索ワード Simple-Query-String-Syntaxをパースして検索します  (optional) 
            var after = 2006-01-02T15:04:05Z;  // DateTimeOffset? | 投稿日時が指定日時より後 (optional) 
            var before = 2006-01-02T15:04:05Z;  // DateTimeOffset? | 投稿日時が指定日時より前 (optional) 
            var varIn = "varIn_example";  // Guid? | メッセージが投稿されたチャンネル (optional) 
            var to = new List<Guid>?(); // List<Guid>? | メンションされたユーザー (optional) 
            var from = new List<Guid>?(); // List<Guid>? | メッセージを投稿したユーザー (optional) 
            var citation = "citation_example";  // Guid? | 引用しているメッセージ (optional) 
            var bot = true;  // bool? | メッセージを投稿したユーザーがBotかどうか (optional) 
            var hasURL = true;  // bool? | メッセージがURLを含むか (optional) 
            var hasAttachments = true;  // bool? | メッセージが添付ファイルを含むか (optional) 
            var hasImage = true;  // bool? | メッセージが画像を含むか (optional) 
            var hasVideo = true;  // bool? | メッセージが動画を含むか (optional) 
            var hasAudio = true;  // bool? | メッセージが音声ファイルを含むか (optional) 
            var limit = 56;  // int? | 検索結果から取得するメッセージの最大件数 (optional) 
            var offset = 56;  // int? | 検索結果から取得するメッセージのオフセット (optional) 
            var sort = "createdAt";  // string? | ソート順 (作成日時が新しい `createdAt`, 作成日時が古い `-createdAt`, 更新日時が新しい `updatedAt`, 更新日時が古い `-updatedAt`) (optional)  (default to -createdAt)

            try
            {
                // メッセージを検索
                MessageSearchResult result = apiInstance.SearchMessages(word, after, before, varIn, to, from, citation, bot, hasURL, hasAttachments, hasImage, hasVideo, hasAudio, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageApi.SearchMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージを検索
    ApiResponse<MessageSearchResult> response = apiInstance.SearchMessagesWithHttpInfo(word, after, before, varIn, to, from, citation, bot, hasURL, hasAttachments, hasImage, hasVideo, hasAudio, limit, offset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageApi.SearchMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **word** | **string?** | 検索ワード Simple-Query-String-Syntaxをパースして検索します  | [optional]  |
| **after** | **DateTimeOffset?** | 投稿日時が指定日時より後 | [optional]  |
| **before** | **DateTimeOffset?** | 投稿日時が指定日時より前 | [optional]  |
| **varIn** | **Guid?** | メッセージが投稿されたチャンネル | [optional]  |
| **to** | [**List&lt;Guid&gt;?**](Guid.md) | メンションされたユーザー | [optional]  |
| **from** | [**List&lt;Guid&gt;?**](Guid.md) | メッセージを投稿したユーザー | [optional]  |
| **citation** | **Guid?** | 引用しているメッセージ | [optional]  |
| **bot** | **bool?** | メッセージを投稿したユーザーがBotかどうか | [optional]  |
| **hasURL** | **bool?** | メッセージがURLを含むか | [optional]  |
| **hasAttachments** | **bool?** | メッセージが添付ファイルを含むか | [optional]  |
| **hasImage** | **bool?** | メッセージが画像を含むか | [optional]  |
| **hasVideo** | **bool?** | メッセージが動画を含むか | [optional]  |
| **hasAudio** | **bool?** | メッセージが音声ファイルを含むか | [optional]  |
| **limit** | **int?** | 検索結果から取得するメッセージの最大件数 | [optional]  |
| **offset** | **int?** | 検索結果から取得するメッセージのオフセット | [optional]  |
| **sort** | **string?** | ソート順 (作成日時が新しい &#x60;createdAt&#x60;, 作成日時が古い &#x60;-createdAt&#x60;, 更新日時が新しい &#x60;updatedAt&#x60;, 更新日時が古い &#x60;-updatedAt&#x60;) | [optional] [default to -createdAt] |

### Return type

[**MessageSearchResult**](MessageSearchResult.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **503** | search service is currently unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

