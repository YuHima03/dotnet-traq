# Traq.Api.BotApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateBot**](BotApi.md#activatebot) | **POST** /bots/{botId}/actions/activate | BOTをアクティベート |
| [**ChangeBotIcon**](BotApi.md#changeboticon) | **PUT** /bots/{botId}/icon | BOTのアイコン画像を変更 |
| [**ConnectBotWS**](BotApi.md#connectbotws) | **GET** /bots/ws | WebSocket Mode BOT用通知ストリームに接続します |
| [**CreateBot**](BotApi.md#createbot) | **POST** /bots | BOTを作成 |
| [**DeleteBot**](BotApi.md#deletebot) | **DELETE** /bots/{botId} | BOTを削除 |
| [**EditBot**](BotApi.md#editbot) | **PATCH** /bots/{botId} | BOT情報を変更 |
| [**GetBot**](BotApi.md#getbot) | **GET** /bots/{botId} | BOT情報を取得 |
| [**GetBotIcon**](BotApi.md#getboticon) | **GET** /bots/{botId}/icon | BOTのアイコン画像を取得 |
| [**GetBotLogs**](BotApi.md#getbotlogs) | **GET** /bots/{botId}/logs | BOTのイベントログを取得 |
| [**GetBots**](BotApi.md#getbots) | **GET** /bots | BOTリストを取得 |
| [**GetChannelBots**](BotApi.md#getchannelbots) | **GET** /channels/{channelId}/bots | チャンネル参加中のBOTのリストを取得 |
| [**InactivateBot**](BotApi.md#inactivatebot) | **POST** /bots/{botId}/actions/inactivate | BOTをインアクティベート |
| [**LetBotJoinChannel**](BotApi.md#letbotjoinchannel) | **POST** /bots/{botId}/actions/join | BOTをチャンネルに参加させる |
| [**LetBotLeaveChannel**](BotApi.md#letbotleavechannel) | **POST** /bots/{botId}/actions/leave | BOTをチャンネルから退出させる |
| [**ReissueBot**](BotApi.md#reissuebot) | **POST** /bots/{botId}/actions/reissue | BOTのトークンを再発行 |

<a id="activatebot"></a>
# **ActivateBot**
> void ActivateBot (Guid botId)

BOTをアクティベート

指定したBOTを有効化します。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ActivateBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID

            try
            {
                // BOTをアクティベート
                apiInstance.ActivateBot(botId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.ActivateBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTをアクティベート
    apiInstance.ActivateBotWithHttpInfo(botId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.ActivateBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **202** | Accepted |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeboticon"></a>
# **ChangeBotIcon**
> void ChangeBotIcon (Guid botId, System.IO.Stream file)

BOTのアイコン画像を変更

指定したBOTのアイコン画像を変更を変更します。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ChangeBotIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | アイコン画像(2MBまでのpng, jpeg, gif)

            try
            {
                // BOTのアイコン画像を変更
                apiInstance.ChangeBotIcon(botId, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.ChangeBotIcon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeBotIconWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTのアイコン画像を変更
    apiInstance.ChangeBotIconWithHttpInfo(botId, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.ChangeBotIconWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **file** | **System.IO.Stream****System.IO.Stream** | アイコン画像(2MBまでのpng, jpeg, gif) |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="connectbotws"></a>
# **ConnectBotWS**
> void ConnectBotWS ()

WebSocket Mode BOT用通知ストリームに接続します

# BOT WebSocketプロトコル  ## 送信  `コマンド:引数1:引数2:...` のような形式のTextMessageをサーバーに送信することで、このWebSocketセッションに対する設定が実行できます。  ### `rtcstate`コマンド 自分のWebRTC状態を変更します。 他のコネクションが既に状態を保持している場合、変更することができません。  `rtcstate:{チャンネルID}:({状態}:{セッションID})*`  チャンネルIDにnullもしくは空文字を指定するか、状態にnullもしくは空文字を指定した場合、WebRTC状態はリセットされます。  `rtcstate:null`, `rtcstate:`, `rtcstate:channelId:null`, `rtcstate:channelId:`  コネクションが切断された場合、自分のWebRTC状態はリセットされます。  ## 受信  TextMessageとして各種イベントが`type`、`reqId`、`body`を持つJSONとして非同期に送られます。 `body`の内容はHTTP Modeの場合のRequest Bodyと同様です。 例外として`ERROR`イベントは`reqId`を持ちません。  例: PINGイベント `{\"type\":\"PING\",\"reqId\":\"requestId\",\"body\":{\"eventTime\":\"2019-05-07T04:50:48.582586882Z\"}}`  ### `ERROR`  コマンドの引数が不正などの理由でコマンドが受理されなかった場合に送られます。 非同期に送られるため、必ずしもコマンドとの対応関係を確定できないことに注意してください。 本番環境ではERRORが送られないようにすることが望ましいです。  `{\"type\":\"ERROR\",\"body\":\"message\"}`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ConnectBotWSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);

            try
            {
                // WebSocket Mode BOT用通知ストリームに接続します
                apiInstance.ConnectBotWS();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.ConnectBotWS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConnectBotWSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // WebSocket Mode BOT用通知ストリームに接続します
    apiInstance.ConnectBotWSWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.ConnectBotWSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **101** | Switching Protocols |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createbot"></a>
# **CreateBot**
> BotDetail CreateBot (PostBotRequest postBotRequest = null)

BOTを作成

BOTを作成します。 作成後に購読イベントの設定を行う必要があります。 さらにHTTP Modeの場合はアクティベーションを行う必要があります。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class CreateBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var postBotRequest = new PostBotRequest(); // PostBotRequest |  (optional) 

            try
            {
                // BOTを作成
                BotDetail result = apiInstance.CreateBot(postBotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.CreateBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTを作成
    ApiResponse<BotDetail> response = apiInstance.CreateBotWithHttpInfo(postBotRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.CreateBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postBotRequest** | [**PostBotRequest**](PostBotRequest.md) |  | [optional]  |

### Return type

[**BotDetail**](BotDetail.md)

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
| **409** | Conflict 既に使われている名前です。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletebot"></a>
# **DeleteBot**
> void DeleteBot (Guid botId)

BOTを削除

指定したBOTを削除します。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class DeleteBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID

            try
            {
                // BOTを削除
                apiInstance.DeleteBot(botId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.DeleteBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTを削除
    apiInstance.DeleteBotWithHttpInfo(botId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.DeleteBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editbot"></a>
# **EditBot**
> void EditBot (Guid botId, PatchBotRequest patchBotRequest = null)

BOT情報を変更

指定したBOTの情報を変更します。 対象のBOTの管理権限が必要です。 BOT開発者UUIDを変更した場合は、変更先ユーザーにBOT管理権限が移譲され、自分自身は権限を失います。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class EditBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID
            var patchBotRequest = new PatchBotRequest(); // PatchBotRequest |  (optional) 

            try
            {
                // BOT情報を変更
                apiInstance.EditBot(botId, patchBotRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.EditBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOT情報を変更
    apiInstance.EditBotWithHttpInfo(botId, patchBotRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.EditBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **patchBotRequest** | [**PatchBotRequest**](PatchBotRequest.md) |  | [optional]  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbot"></a>
# **GetBot**
> GetBot200Response GetBot (Guid botId, bool detail = null)

BOT情報を取得

指定したBOTのBOT情報を取得します。 BOT詳細情報を取得する場合は、対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID
            var detail = false;  // bool | 詳細情報を含めるかどうか (optional)  (default to false)

            try
            {
                // BOT情報を取得
                GetBot200Response result = apiInstance.GetBot(botId, detail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.GetBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOT情報を取得
    ApiResponse<GetBot200Response> response = apiInstance.GetBotWithHttpInfo(botId, detail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.GetBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **detail** | **bool** | 詳細情報を含めるかどうか | [optional] [default to false] |

### Return type

[**GetBot200Response**](GetBot200Response.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getboticon"></a>
# **GetBotIcon**
> System.IO.Stream GetBotIcon (Guid botId)

BOTのアイコン画像を取得

指定したBOTのアイコン画像を取得を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetBotIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID

            try
            {
                // BOTのアイコン画像を取得
                System.IO.Stream result = apiInstance.GetBotIcon(botId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.GetBotIcon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBotIconWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTのアイコン画像を取得
    ApiResponse<System.IO.Stream> response = apiInstance.GetBotIconWithHttpInfo(botId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.GetBotIconWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/jpeg, image/gif, image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbotlogs"></a>
# **GetBotLogs**
> List&lt;BotEventLog&gt; GetBotLogs (Guid botId, int limit = null, int offset = null)

BOTのイベントログを取得

指定したBOTのイベントログを取得します。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetBotLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID
            var limit = 50;  // int | 取得する件数 (optional) 
            var offset = 150;  // int | 取得するオフセット (optional)  (default to 0)

            try
            {
                // BOTのイベントログを取得
                List<BotEventLog> result = apiInstance.GetBotLogs(botId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.GetBotLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBotLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTのイベントログを取得
    ApiResponse<List<BotEventLog>> response = apiInstance.GetBotLogsWithHttpInfo(botId, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.GetBotLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **limit** | **int** | 取得する件数 | [optional]  |
| **offset** | **int** | 取得するオフセット | [optional] [default to 0] |

### Return type

[**List&lt;BotEventLog&gt;**](BotEventLog.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbots"></a>
# **GetBots**
> List&lt;Bot&gt; GetBots (bool all = null)

BOTリストを取得

BOT情報のリストを取得します。 allを指定しない場合、自分が開発者のBOTのみを返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetBotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var all = false;  // bool | 全てのBOTを取得するかどうか (optional)  (default to false)

            try
            {
                // BOTリストを取得
                List<Bot> result = apiInstance.GetBots(all);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.GetBots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTリストを取得
    ApiResponse<List<Bot>> response = apiInstance.GetBotsWithHttpInfo(all);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.GetBotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **all** | **bool** | 全てのBOTを取得するかどうか | [optional] [default to false] |

### Return type

[**List&lt;Bot&gt;**](Bot.md)

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

<a id="getchannelbots"></a>
# **GetChannelBots**
> List&lt;BotUser&gt; GetChannelBots (Guid channelId)

チャンネル参加中のBOTのリストを取得

指定したチャンネルに参加しているBOTのリストを取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetChannelBotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var channelId = "channelId_example";  // Guid | チャンネルUUID

            try
            {
                // チャンネル参加中のBOTのリストを取得
                List<BotUser> result = apiInstance.GetChannelBots(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.GetChannelBots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChannelBotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネル参加中のBOTのリストを取得
    ApiResponse<List<BotUser>> response = apiInstance.GetChannelBotsWithHttpInfo(channelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.GetChannelBotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**List&lt;BotUser&gt;**](BotUser.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="inactivatebot"></a>
# **InactivateBot**
> void InactivateBot (Guid botId)

BOTをインアクティベート

指定したBOTを無効化します。対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class InactivateBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID

            try
            {
                // BOTをインアクティベート
                apiInstance.InactivateBot(botId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.InactivateBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InactivateBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTをインアクティベート
    apiInstance.InactivateBotWithHttpInfo(botId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.InactivateBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **204** | No Content BOTがインアクティベートされました。 |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="letbotjoinchannel"></a>
# **LetBotJoinChannel**
> void LetBotJoinChannel (Guid botId, PostBotActionJoinRequest postBotActionJoinRequest = null)

BOTをチャンネルに参加させる

指定したBOTを指定したチャンネルに参加させます。 チャンネルに参加したBOTは、そのチャンネルの各種イベントを受け取るようになります。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class LetBotJoinChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID
            var postBotActionJoinRequest = new PostBotActionJoinRequest(); // PostBotActionJoinRequest |  (optional) 

            try
            {
                // BOTをチャンネルに参加させる
                apiInstance.LetBotJoinChannel(botId, postBotActionJoinRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.LetBotJoinChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LetBotJoinChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTをチャンネルに参加させる
    apiInstance.LetBotJoinChannelWithHttpInfo(botId, postBotActionJoinRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.LetBotJoinChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **postBotActionJoinRequest** | [**PostBotActionJoinRequest**](PostBotActionJoinRequest.md) |  | [optional]  |

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
| **204** | No Content BOTを参加させました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="letbotleavechannel"></a>
# **LetBotLeaveChannel**
> void LetBotLeaveChannel (Guid botId, PostBotActionLeaveRequest postBotActionLeaveRequest = null)

BOTをチャンネルから退出させる

指定したBOTを指定したチャンネルから退出させます。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class LetBotLeaveChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID
            var postBotActionLeaveRequest = new PostBotActionLeaveRequest(); // PostBotActionLeaveRequest |  (optional) 

            try
            {
                // BOTをチャンネルから退出させる
                apiInstance.LetBotLeaveChannel(botId, postBotActionLeaveRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.LetBotLeaveChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LetBotLeaveChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTをチャンネルから退出させる
    apiInstance.LetBotLeaveChannelWithHttpInfo(botId, postBotActionLeaveRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.LetBotLeaveChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **postBotActionLeaveRequest** | [**PostBotActionLeaveRequest**](PostBotActionLeaveRequest.md) |  | [optional]  |

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
| **204** | No Content BOTを退出させました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="reissuebot"></a>
# **ReissueBot**
> BotTokens ReissueBot (Guid botId)

BOTのトークンを再発行

指定したBOTの現在の各種トークンを無効化し、再発行を行います。 対象のBOTの管理権限が必要です。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ReissueBotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BotApi(config);
            var botId = "botId_example";  // Guid | BOTUUID

            try
            {
                // BOTのトークンを再発行
                BotTokens result = apiInstance.ReissueBot(botId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotApi.ReissueBot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReissueBotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BOTのトークンを再発行
    ApiResponse<BotTokens> response = apiInstance.ReissueBotWithHttpInfo(botId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BotApi.ReissueBotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

### Return type

[**BotTokens**](BotTokens.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

