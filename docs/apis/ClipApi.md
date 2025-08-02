# Traq.Api.ClipApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClipMessage**](ClipApi.md#clipmessage) | **POST** /clip-folders/{folderId}/messages | メッセージをクリップフォルダに追加 |
| [**CreateClipFolder**](ClipApi.md#createclipfolder) | **POST** /clip-folders | クリップフォルダを作成 |
| [**DeleteClipFolder**](ClipApi.md#deleteclipfolder) | **DELETE** /clip-folders/{folderId} | クリップフォルダを削除 |
| [**EditClipFolder**](ClipApi.md#editclipfolder) | **PATCH** /clip-folders/{folderId} | クリップフォルダ情報を編集 |
| [**GetClipFolder**](ClipApi.md#getclipfolder) | **GET** /clip-folders/{folderId} | クリップフォルダ情報を取得 |
| [**GetClipFolders**](ClipApi.md#getclipfolders) | **GET** /clip-folders | クリップフォルダのリストを取得 |
| [**GetClips**](ClipApi.md#getclips) | **GET** /clip-folders/{folderId}/messages | フォルダ内のクリップのリストを取得 |
| [**GetMessageClips**](ClipApi.md#getmessageclips) | **GET** /messages/{messageId}/clips | 自分のクリップを取得 |
| [**UnclipMessage**](ClipApi.md#unclipmessage) | **DELETE** /clip-folders/{folderId}/messages/{messageId} | メッセージをクリップフォルダから除外 |

<a id="clipmessage"></a>
# **ClipMessage**
> ClippedMessage ClipMessage (Guid folderId, PostClipFolderMessageRequest postClipFolderMessageRequest = null)

メッセージをクリップフォルダに追加

指定したメッセージを指定したクリップフォルダに追加します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ClipMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var folderId = "folderId_example";  // Guid | クリップフォルダUUID
            var postClipFolderMessageRequest = new PostClipFolderMessageRequest(); // PostClipFolderMessageRequest |  (optional) 

            try
            {
                // メッセージをクリップフォルダに追加
                ClippedMessage result = apiInstance.ClipMessage(folderId, postClipFolderMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.ClipMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClipMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージをクリップフォルダに追加
    ApiResponse<ClippedMessage> response = apiInstance.ClipMessageWithHttpInfo(folderId, postClipFolderMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.ClipMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
| **postClipFolderMessageRequest** | [**PostClipFolderMessageRequest**](PostClipFolderMessageRequest.md) |  | [optional]  |

### Return type

[**ClippedMessage**](ClippedMessage.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |
| **409** | Conflict 既に追加されています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createclipfolder"></a>
# **CreateClipFolder**
> ClipFolder CreateClipFolder (PostClipFolderRequest postClipFolderRequest = null)

クリップフォルダを作成

クリップフォルダを作成します。 既にあるフォルダと同名のフォルダを作成することは可能です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class CreateClipFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var postClipFolderRequest = new PostClipFolderRequest(); // PostClipFolderRequest |  (optional) 

            try
            {
                // クリップフォルダを作成
                ClipFolder result = apiInstance.CreateClipFolder(postClipFolderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.CreateClipFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClipFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // クリップフォルダを作成
    ApiResponse<ClipFolder> response = apiInstance.CreateClipFolderWithHttpInfo(postClipFolderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.CreateClipFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postClipFolderRequest** | [**PostClipFolderRequest**](PostClipFolderRequest.md) |  | [optional]  |

### Return type

[**ClipFolder**](ClipFolder.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteclipfolder"></a>
# **DeleteClipFolder**
> void DeleteClipFolder (Guid folderId)

クリップフォルダを削除

指定したクリップフォルダを削除します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class DeleteClipFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var folderId = "folderId_example";  // Guid | クリップフォルダUUID

            try
            {
                // クリップフォルダを削除
                apiInstance.DeleteClipFolder(folderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.DeleteClipFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteClipFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // クリップフォルダを削除
    apiInstance.DeleteClipFolderWithHttpInfo(folderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.DeleteClipFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |

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
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editclipfolder"></a>
# **EditClipFolder**
> void EditClipFolder (Guid folderId, PatchClipFolderRequest patchClipFolderRequest = null)

クリップフォルダ情報を編集

指定したクリップフォルダの情報を編集します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class EditClipFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var folderId = "folderId_example";  // Guid | クリップフォルダUUID
            var patchClipFolderRequest = new PatchClipFolderRequest(); // PatchClipFolderRequest |  (optional) 

            try
            {
                // クリップフォルダ情報を編集
                apiInstance.EditClipFolder(folderId, patchClipFolderRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.EditClipFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditClipFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // クリップフォルダ情報を編集
    apiInstance.EditClipFolderWithHttpInfo(folderId, patchClipFolderRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.EditClipFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
| **patchClipFolderRequest** | [**PatchClipFolderRequest**](PatchClipFolderRequest.md) |  | [optional]  |

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
| **204** | No Content 編集しました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclipfolder"></a>
# **GetClipFolder**
> ClipFolder GetClipFolder (Guid folderId)

クリップフォルダ情報を取得

指定したクリップフォルダの情報を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetClipFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var folderId = "folderId_example";  // Guid | クリップフォルダUUID

            try
            {
                // クリップフォルダ情報を取得
                ClipFolder result = apiInstance.GetClipFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.GetClipFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClipFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // クリップフォルダ情報を取得
    ApiResponse<ClipFolder> response = apiInstance.GetClipFolderWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.GetClipFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |

### Return type

[**ClipFolder**](ClipFolder.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclipfolders"></a>
# **GetClipFolders**
> List&lt;ClipFolder&gt; GetClipFolders ()

クリップフォルダのリストを取得

自身が所有するクリップフォルダのリストを取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetClipFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);

            try
            {
                // クリップフォルダのリストを取得
                List<ClipFolder> result = apiInstance.GetClipFolders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.GetClipFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClipFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // クリップフォルダのリストを取得
    ApiResponse<List<ClipFolder>> response = apiInstance.GetClipFoldersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.GetClipFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ClipFolder&gt;**](ClipFolder.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclips"></a>
# **GetClips**
> List&lt;ClippedMessage&gt; GetClips (Guid folderId, int limit = null, int offset = null, string order = null)

フォルダ内のクリップのリストを取得

指定したフォルダ内のクリップのリストを取得します。 `order`を指定しない場合、クリップした日時の新しい順で返されます。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetClipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var folderId = "folderId_example";  // Guid | クリップフォルダUUID
            var limit = 50;  // int | 取得する件数 (optional) 
            var offset = 150;  // int | 取得するオフセット (optional)  (default to 0)
            var order = "asc";  // string | 昇順か降順か (optional)  (default to desc)

            try
            {
                // フォルダ内のクリップのリストを取得
                List<ClippedMessage> result = apiInstance.GetClips(folderId, limit, offset, order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.GetClips: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // フォルダ内のクリップのリストを取得
    ApiResponse<List<ClippedMessage>> response = apiInstance.GetClipsWithHttpInfo(folderId, limit, offset, order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.GetClipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
| **limit** | **int** | 取得する件数 | [optional]  |
| **offset** | **int** | 取得するオフセット | [optional] [default to 0] |
| **order** | **string** | 昇順か降順か | [optional] [default to desc] |

### Return type

[**List&lt;ClippedMessage&gt;**](ClippedMessage.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmessageclips"></a>
# **GetMessageClips**
> List&lt;MessageClip&gt; GetMessageClips (Guid messageId)

自分のクリップを取得

対象のメッセージの自分のクリップの一覧を返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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

            var apiInstance = new ClipApi(config);
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // 自分のクリップを取得
                List<MessageClip> result = apiInstance.GetMessageClips(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.GetMessageClips: " + e.Message);
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
    Debug.Print("Exception when calling ClipApi.GetMessageClipsWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="unclipmessage"></a>
# **UnclipMessage**
> void UnclipMessage (Guid folderId, Guid messageId)

メッセージをクリップフォルダから除外

指定したフォルダから指定したメッセージのクリップを除外します。 既に外されているメッセージを指定した場合は204を返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class UnclipMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ClipApi(config);
            var folderId = "folderId_example";  // Guid | クリップフォルダUUID
            var messageId = "messageId_example";  // Guid | メッセージUUID

            try
            {
                // メッセージをクリップフォルダから除外
                apiInstance.UnclipMessage(folderId, messageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClipApi.UnclipMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnclipMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージをクリップフォルダから除外
    apiInstance.UnclipMessageWithHttpInfo(folderId, messageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClipApi.UnclipMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
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
| **204** | No Content 外しました。 |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

