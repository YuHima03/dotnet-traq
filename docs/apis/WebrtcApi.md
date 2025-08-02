# Traq.Api.WebrtcApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetWebRTCState**](WebrtcApi.md#getwebrtcstate) | **GET** /webrtc/state | WebRTC状態を取得 |
| [**PostWebRTCAuthenticate**](WebrtcApi.md#postwebrtcauthenticate) | **POST** /webrtc/authenticate | Skyway用認証API |

<a id="getwebrtcstate"></a>
# **GetWebRTCState**
> List&lt;WebRTCUserState&gt; GetWebRTCState ()

WebRTC状態を取得

現在のWebRTC状態を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetWebRTCStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebrtcApi(config);

            try
            {
                // WebRTC状態を取得
                List<WebRTCUserState> result = apiInstance.GetWebRTCState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebrtcApi.GetWebRTCState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebRTCStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // WebRTC状態を取得
    ApiResponse<List<WebRTCUserState>> response = apiInstance.GetWebRTCStateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebrtcApi.GetWebRTCStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WebRTCUserState&gt;**](WebRTCUserState.md)

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

<a id="postwebrtcauthenticate"></a>
# **PostWebRTCAuthenticate**
> WebRTCAuthenticateResult PostWebRTCAuthenticate (PostWebRTCAuthenticateRequest postWebRTCAuthenticateRequest = null)

Skyway用認証API

Skyway WebRTC用の認証API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class PostWebRTCAuthenticateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WebrtcApi(config);
            var postWebRTCAuthenticateRequest = new PostWebRTCAuthenticateRequest(); // PostWebRTCAuthenticateRequest |  (optional) 

            try
            {
                // Skyway用認証API
                WebRTCAuthenticateResult result = apiInstance.PostWebRTCAuthenticate(postWebRTCAuthenticateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebrtcApi.PostWebRTCAuthenticate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWebRTCAuthenticateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Skyway用認証API
    ApiResponse<WebRTCAuthenticateResult> response = apiInstance.PostWebRTCAuthenticateWithHttpInfo(postWebRTCAuthenticateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebrtcApi.PostWebRTCAuthenticateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postWebRTCAuthenticateRequest** | [**PostWebRTCAuthenticateRequest**](PostWebRTCAuthenticateRequest.md) |  | [optional]  |

### Return type

[**WebRTCAuthenticateResult**](WebRTCAuthenticateResult.md)

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
| **503** | Service Unavailable WebRTCは現在機能を停止しています |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

