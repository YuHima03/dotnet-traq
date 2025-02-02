# Traq.Api.StampApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMessageStamp**](StampApi.md#addmessagestamp) | **POST** /messages/{messageId}/stamps/{stampId} | スタンプを押す |
| [**ChangeStampImage**](StampApi.md#changestampimage) | **PUT** /stamps/{stampId}/image | スタンプ画像を変更 |
| [**CreateStamp**](StampApi.md#createstamp) | **POST** /stamps | スタンプを作成 |
| [**CreateStampPalette**](StampApi.md#createstamppalette) | **POST** /stamp-palettes | スタンプパレットを作成 |
| [**DeleteStamp**](StampApi.md#deletestamp) | **DELETE** /stamps/{stampId} | スタンプを削除 |
| [**DeleteStampPalette**](StampApi.md#deletestamppalette) | **DELETE** /stamp-palettes/{paletteId} | スタンプパレットを削除 |
| [**EditStamp**](StampApi.md#editstamp) | **PATCH** /stamps/{stampId} | スタンプ情報を変更 |
| [**EditStampPalette**](StampApi.md#editstamppalette) | **PATCH** /stamp-palettes/{paletteId} | スタンプパレットを編集 |
| [**GetMessageStamps**](StampApi.md#getmessagestamps) | **GET** /messages/{messageId}/stamps | メッセージのスタンプリストを取得 |
| [**GetMyStampHistory**](StampApi.md#getmystamphistory) | **GET** /users/me/stamp-history | スタンプ履歴を取得 |
| [**GetStamp**](StampApi.md#getstamp) | **GET** /stamps/{stampId} | スタンプ情報を取得 |
| [**GetStampImage**](StampApi.md#getstampimage) | **GET** /stamps/{stampId}/image | スタンプ画像を取得 |
| [**GetStampPalette**](StampApi.md#getstamppalette) | **GET** /stamp-palettes/{paletteId} | スタンプパレットを取得 |
| [**GetStampPalettes**](StampApi.md#getstamppalettes) | **GET** /stamp-palettes | スタンプパレットのリストを取得 |
| [**GetStampStats**](StampApi.md#getstampstats) | **GET** /stamps/{stampId}/stats | スタンプ統計情報を取得 |
| [**GetStamps**](StampApi.md#getstamps) | **GET** /stamps | スタンプリストを取得 |
| [**RemoveMessageStamp**](StampApi.md#removemessagestamp) | **DELETE** /messages/{messageId}/stamps/{stampId} | スタンプを消す |

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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling StampApi.AddMessageStamp: " + e.Message);
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
    Debug.Print("Exception when calling StampApi.AddMessageStampWithHttpInfo: " + e.Message);
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

<a id="changestampimage"></a>
# **ChangeStampImage**
> void ChangeStampImage (Guid stampId, FileParameter file)

スタンプ画像を変更

指定したスタンプの画像を変更します。

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
    public class ChangeStampImageExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var stampId = "stampId_example";  // Guid | スタンプUUID
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | スタンプ画像(1MBまでのpng, jpeg, gif)

            try
            {
                // スタンプ画像を変更
                apiInstance.ChangeStampImage(stampId, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.ChangeStampImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeStampImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプ画像を変更
    apiInstance.ChangeStampImageWithHttpInfo(stampId, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.ChangeStampImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |
| **file** | **FileParameter****FileParameter** | スタンプ画像(1MBまでのpng, jpeg, gif) |  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createstamp"></a>
# **CreateStamp**
> Stamp CreateStamp (string name, FileParameter file)

スタンプを作成

スタンプを新規作成します。

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
    public class CreateStampExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | スタンプ名
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | スタンプ画像(1MBまでのpng, jpeg, gif)

            try
            {
                // スタンプを作成
                Stamp result = apiInstance.CreateStamp(name, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.CreateStamp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStampWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプを作成
    ApiResponse<Stamp> response = apiInstance.CreateStampWithHttpInfo(name, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.CreateStampWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | スタンプ名 |  |
| **file** | **FileParameter****FileParameter** | スタンプ画像(1MBまでのpng, jpeg, gif) |  |

### Return type

[**Stamp**](Stamp.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createstamppalette"></a>
# **CreateStampPalette**
> StampPalette CreateStampPalette (PostStampPaletteRequest? postStampPaletteRequest = null)

スタンプパレットを作成

スタンプパレットを作成します。

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
    public class CreateStampPaletteExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var postStampPaletteRequest = new PostStampPaletteRequest?(); // PostStampPaletteRequest? |  (optional) 

            try
            {
                // スタンプパレットを作成
                StampPalette result = apiInstance.CreateStampPalette(postStampPaletteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.CreateStampPalette: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStampPaletteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプパレットを作成
    ApiResponse<StampPalette> response = apiInstance.CreateStampPaletteWithHttpInfo(postStampPaletteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.CreateStampPaletteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postStampPaletteRequest** | [**PostStampPaletteRequest?**](PostStampPaletteRequest?.md) |  | [optional]  |

### Return type

[**StampPalette**](StampPalette.md)

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

<a id="deletestamp"></a>
# **DeleteStamp**
> void DeleteStamp (Guid stampId)

スタンプを削除

指定したスタンプを削除します。 対象のスタンプの削除権限が必要です。

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
    public class DeleteStampExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var stampId = "stampId_example";  // Guid | スタンプUUID

            try
            {
                // スタンプを削除
                apiInstance.DeleteStamp(stampId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.DeleteStamp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStampWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプを削除
    apiInstance.DeleteStampWithHttpInfo(stampId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.DeleteStampWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **204** | No Content スタンプが削除されました。 |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletestamppalette"></a>
# **DeleteStampPalette**
> void DeleteStampPalette (Guid paletteId)

スタンプパレットを削除

指定したスタンプパレットを削除します。 対象のスタンプパレットの管理権限が必要です。

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
    public class DeleteStampPaletteExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var paletteId = "paletteId_example";  // Guid | スタンプパレットUUID

            try
            {
                // スタンプパレットを削除
                apiInstance.DeleteStampPalette(paletteId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.DeleteStampPalette: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStampPaletteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプパレットを削除
    apiInstance.DeleteStampPaletteWithHttpInfo(paletteId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.DeleteStampPaletteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paletteId** | **Guid** | スタンプパレットUUID |  |

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
| **204** | No Content 削除しました。 |  -  |
| **403** | Forbidden 対象のスタンプパレットを削除する権限がありません。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editstamp"></a>
# **EditStamp**
> void EditStamp (Guid stampId, PatchStampRequest? patchStampRequest = null)

スタンプ情報を変更

指定したスタンプの情報を変更します。

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
    public class EditStampExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var stampId = "stampId_example";  // Guid | スタンプUUID
            var patchStampRequest = new PatchStampRequest?(); // PatchStampRequest? |  (optional) 

            try
            {
                // スタンプ情報を変更
                apiInstance.EditStamp(stampId, patchStampRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.EditStamp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditStampWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプ情報を変更
    apiInstance.EditStampWithHttpInfo(stampId, patchStampRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.EditStampWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |
| **patchStampRequest** | [**PatchStampRequest?**](PatchStampRequest?.md) |  | [optional]  |

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
| **204** | No Content スタンプ情報が変更されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editstamppalette"></a>
# **EditStampPalette**
> void EditStampPalette (Guid paletteId, PatchStampPaletteRequest? patchStampPaletteRequest = null)

スタンプパレットを編集

指定したスタンプパレットを編集します。 リクエストのスタンプの配列の順番は保存されて変更されます。 対象のスタンプパレットの管理権限が必要です。

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
    public class EditStampPaletteExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var paletteId = "paletteId_example";  // Guid | スタンプパレットUUID
            var patchStampPaletteRequest = new PatchStampPaletteRequest?(); // PatchStampPaletteRequest? |  (optional) 

            try
            {
                // スタンプパレットを編集
                apiInstance.EditStampPalette(paletteId, patchStampPaletteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.EditStampPalette: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditStampPaletteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプパレットを編集
    apiInstance.EditStampPaletteWithHttpInfo(paletteId, patchStampPaletteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.EditStampPaletteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paletteId** | **Guid** | スタンプパレットUUID |  |
| **patchStampPaletteRequest** | [**PatchStampPaletteRequest?**](PatchStampPaletteRequest?.md) |  | [optional]  |

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
| **204** | No Content 変更しました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden 対象のスタンプパレットを編集する権限がありません。 |  -  |
| **404** | Not Found |  -  |

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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // メッセージのスタンプリストを取得
                List<MessageStamp> result = apiInstance.GetMessageStamps(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetMessageStamps: " + e.Message);
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
    Debug.Print("Exception when calling StampApi.GetMessageStampsWithHttpInfo: " + e.Message);
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

<a id="getmystamphistory"></a>
# **GetMyStampHistory**
> List&lt;StampHistoryEntry&gt; GetMyStampHistory (int? limit = null)

スタンプ履歴を取得

自分のスタンプ履歴を最大100件まで取得します。 結果は降順で返されます。  このAPIが返すスタンプ履歴は厳密な履歴ではありません。

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
    public class GetMyStampHistoryExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var limit = 100;  // int? | 件数 (optional)  (default to 100)

            try
            {
                // スタンプ履歴を取得
                List<StampHistoryEntry> result = apiInstance.GetMyStampHistory(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetMyStampHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyStampHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプ履歴を取得
    ApiResponse<List<StampHistoryEntry>> response = apiInstance.GetMyStampHistoryWithHttpInfo(limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetMyStampHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | 件数 | [optional] [default to 100] |

### Return type

[**List&lt;StampHistoryEntry&gt;**](StampHistoryEntry.md)

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

<a id="getstamp"></a>
# **GetStamp**
> Stamp GetStamp (Guid stampId)

スタンプ情報を取得

指定したスタンプの情報を取得します。

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
    public class GetStampExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var stampId = "stampId_example";  // Guid | スタンプUUID

            try
            {
                // スタンプ情報を取得
                Stamp result = apiInstance.GetStamp(stampId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetStamp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStampWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプ情報を取得
    ApiResponse<Stamp> response = apiInstance.GetStampWithHttpInfo(stampId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetStampWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |

### Return type

[**Stamp**](Stamp.md)

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

<a id="getstampimage"></a>
# **GetStampImage**
> FileParameter GetStampImage (Guid stampId)

スタンプ画像を取得

指定したIDのスタンプ画像を返します。

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
    public class GetStampImageExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var stampId = "stampId_example";  // Guid | スタンプUUID

            try
            {
                // スタンプ画像を取得
                FileParameter result = apiInstance.GetStampImage(stampId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetStampImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStampImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプ画像を取得
    ApiResponse<FileParameter> response = apiInstance.GetStampImageWithHttpInfo(stampId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetStampImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, image/gif, image/jpeg


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstamppalette"></a>
# **GetStampPalette**
> StampPalette GetStampPalette (Guid paletteId)

スタンプパレットを取得

指定したスタンプパレットの情報を取得します。

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
    public class GetStampPaletteExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var paletteId = "paletteId_example";  // Guid | スタンプパレットUUID

            try
            {
                // スタンプパレットを取得
                StampPalette result = apiInstance.GetStampPalette(paletteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetStampPalette: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStampPaletteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプパレットを取得
    ApiResponse<StampPalette> response = apiInstance.GetStampPaletteWithHttpInfo(paletteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetStampPaletteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paletteId** | **Guid** | スタンプパレットUUID |  |

### Return type

[**StampPalette**](StampPalette.md)

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

<a id="getstamppalettes"></a>
# **GetStampPalettes**
> List&lt;StampPalette&gt; GetStampPalettes ()

スタンプパレットのリストを取得

自身が所有しているスタンプパレットのリストを取得します。

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
    public class GetStampPalettesExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);

            try
            {
                // スタンプパレットのリストを取得
                List<StampPalette> result = apiInstance.GetStampPalettes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetStampPalettes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStampPalettesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプパレットのリストを取得
    ApiResponse<List<StampPalette>> response = apiInstance.GetStampPalettesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetStampPalettesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;StampPalette&gt;**](StampPalette.md)

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

<a id="getstampstats"></a>
# **GetStampStats**
> StampStats GetStampStats (Guid stampId)

スタンプ統計情報を取得

指定したスタンプの統計情報を取得します。

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
    public class GetStampStatsExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var stampId = "stampId_example";  // Guid | スタンプUUID

            try
            {
                // スタンプ統計情報を取得
                StampStats result = apiInstance.GetStampStats(stampId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetStampStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStampStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプ統計情報を取得
    ApiResponse<StampStats> response = apiInstance.GetStampStatsWithHttpInfo(stampId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetStampStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |

### Return type

[**StampStats**](StampStats.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found スタンプが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstamps"></a>
# **GetStamps**
> List&lt;StampWithThumbnail&gt; GetStamps (bool? includeUnicode = null, string? type = null)

スタンプリストを取得

スタンプのリストを取得します。

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
    public class GetStampsExample
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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var includeUnicode = true;  // bool? | Unicode絵文字を含ませるかどうか Deprecated: typeクエリを指定しなければ全てのスタンプを取得できるため、そちらを利用してください  (optional)  (default to true)
            var type = "unicode";  // string? | 取得するスタンプの種類 (optional) 

            try
            {
                // スタンプリストを取得
                List<StampWithThumbnail> result = apiInstance.GetStamps(includeUnicode, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.GetStamps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStampsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スタンプリストを取得
    ApiResponse<List<StampWithThumbnail>> response = apiInstance.GetStampsWithHttpInfo(includeUnicode, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StampApi.GetStampsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeUnicode** | **bool?** | Unicode絵文字を含ませるかどうか Deprecated: typeクエリを指定しなければ全てのスタンプを取得できるため、そちらを利用してください  | [optional] [default to true] |
| **type** | **string?** | 取得するスタンプの種類 | [optional]  |

### Return type

[**List&lt;StampWithThumbnail&gt;**](StampWithThumbnail.md)

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
            var apiInstance = new StampApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // Guid | メッセージUUID
            var stampId = "stampId_example";  // Guid | スタンプUUID

            try
            {
                // スタンプを消す
                apiInstance.RemoveMessageStamp(messageId, stampId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StampApi.RemoveMessageStamp: " + e.Message);
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
    Debug.Print("Exception when calling StampApi.RemoveMessageStampWithHttpInfo: " + e.Message);
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

