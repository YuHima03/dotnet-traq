# Traq.Api.ActivityApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetActivityTimeline**](ActivityApi.md#getactivitytimeline) | **GET** /activity/timeline | アクテビティタイムラインを取得 |
| [**GetOnlineUsers**](ActivityApi.md#getonlineusers) | **GET** /activity/onlines | オンラインユーザーリストを取得 |

<a id="getactivitytimeline"></a>
# **GetActivityTimeline**
> List&lt;ActivityTimelineMessage&gt; GetActivityTimeline (int? limit = null, bool? all = null, bool? perChannel = null)

アクテビティタイムラインを取得

パブリックチャンネルの直近の投稿メッセージを作成日時の降順で取得します。 `all`が`true`でない場合、購読チャンネルのみのタイムラインを取得します

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
    public class GetActivityTimelineExample
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
            var apiInstance = new ActivityApi(httpClient, config, httpClientHandler);
            var limit = 50;  // int? | 取得する件数 (optional)  (default to 50)
            var all = false;  // bool? | 全てのチャンネルのタイムラインを取得する (optional)  (default to false)
            var perChannel = false;  // bool? | 同じチャンネルのメッセージは最新のもののみ取得するか (optional)  (default to false)

            try
            {
                // アクテビティタイムラインを取得
                List<ActivityTimelineMessage> result = apiInstance.GetActivityTimeline(limit, all, perChannel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetActivityTimeline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActivityTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // アクテビティタイムラインを取得
    ApiResponse<List<ActivityTimelineMessage>> response = apiInstance.GetActivityTimelineWithHttpInfo(limit, all, perChannel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityApi.GetActivityTimelineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | 取得する件数 | [optional] [default to 50] |
| **all** | **bool?** | 全てのチャンネルのタイムラインを取得する | [optional] [default to false] |
| **perChannel** | **bool?** | 同じチャンネルのメッセージは最新のもののみ取得するか | [optional] [default to false] |

### Return type

[**List&lt;ActivityTimelineMessage&gt;**](ActivityTimelineMessage.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getonlineusers"></a>
# **GetOnlineUsers**
> List&lt;string&gt; GetOnlineUsers ()

オンラインユーザーリストを取得

現在オンラインな(SSEまたはWSが接続中)ユーザーのUUIDのリストを返します。

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
    public class GetOnlineUsersExample
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
            var apiInstance = new ActivityApi(httpClient, config, httpClientHandler);

            try
            {
                // オンラインユーザーリストを取得
                List<string> result = apiInstance.GetOnlineUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetOnlineUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOnlineUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // オンラインユーザーリストを取得
    ApiResponse<List<string>> response = apiInstance.GetOnlineUsersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityApi.GetOnlineUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

