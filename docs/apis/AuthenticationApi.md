# Traq.Api.AuthenticationApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMyExternalAccounts**](AuthenticationApi.md#getmyexternalaccounts) | **GET** /users/me/ex-accounts | 外部ログインアカウント一覧を取得 |
| [**GetMySessions**](AuthenticationApi.md#getmysessions) | **GET** /users/me/sessions | 自分のログインセッションリストを取得 |
| [**LinkExternalAccount**](AuthenticationApi.md#linkexternalaccount) | **POST** /users/me/ex-accounts/link | 外部ログインアカウントを紐付ける |
| [**Login**](AuthenticationApi.md#login) | **POST** /login | ログイン |
| [**Logout**](AuthenticationApi.md#logout) | **POST** /logout | ログアウト |
| [**RevokeMySession**](AuthenticationApi.md#revokemysession) | **DELETE** /users/me/sessions/{sessionId} | セッションを無効化 |
| [**UnlinkExternalAccount**](AuthenticationApi.md#unlinkexternalaccount) | **POST** /users/me/ex-accounts/unlink | 外部ログインアカウントの紐付けを解除 |

<a id="getmyexternalaccounts"></a>
# **GetMyExternalAccounts**
> List&lt;ExternalProviderUser&gt; GetMyExternalAccounts ()

外部ログインアカウント一覧を取得

自分に紐付けられている外部ログインアカウント一覧を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyExternalAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // 外部ログインアカウント一覧を取得
                List<ExternalProviderUser> result = apiInstance.GetMyExternalAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetMyExternalAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyExternalAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部ログインアカウント一覧を取得
    ApiResponse<List<ExternalProviderUser>> response = apiInstance.GetMyExternalAccountsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetMyExternalAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ExternalProviderUser&gt;**](ExternalProviderUser.md)

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

<a id="getmysessions"></a>
# **GetMySessions**
> List&lt;LoginSession&gt; GetMySessions ()

自分のログインセッションリストを取得

自分のログインセッションのリストを取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMySessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // 自分のログインセッションリストを取得
                List<LoginSession> result = apiInstance.GetMySessions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetMySessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMySessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のログインセッションリストを取得
    ApiResponse<List<LoginSession>> response = apiInstance.GetMySessionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetMySessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;LoginSession&gt;**](LoginSession.md)

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

<a id="linkexternalaccount"></a>
# **LinkExternalAccount**
> void LinkExternalAccount (PostLinkExternalAccount postLinkExternalAccount = null)

外部ログインアカウントを紐付ける

自分に外部ログインアカウントを紐付けます。 指定した`providerName`がサーバー側で有効である必要があります。 リクエストが受理された場合、外部サービスの認証画面にリダイレクトされ、認証される必要があります。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class LinkExternalAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var postLinkExternalAccount = new PostLinkExternalAccount(); // PostLinkExternalAccount |  (optional) 

            try
            {
                // 外部ログインアカウントを紐付ける
                apiInstance.LinkExternalAccount(postLinkExternalAccount);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LinkExternalAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkExternalAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部ログインアカウントを紐付ける
    apiInstance.LinkExternalAccountWithHttpInfo(postLinkExternalAccount);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.LinkExternalAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postLinkExternalAccount** | [**PostLinkExternalAccount**](PostLinkExternalAccount.md) |  | [optional]  |

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
| **302** | Found 外部サービスの認証画面に遷移します。 |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="login"></a>
# **Login**
> void Login (string redirect = null, PostLoginRequest postLoginRequest = null)

ログイン

ログインします。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var redirect = "redirect_example";  // string | リダイレクト先 (optional) 
            var postLoginRequest = new PostLoginRequest(); // PostLoginRequest |  (optional) 

            try
            {
                // ログイン
                apiInstance.Login(redirect, postLoginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ログイン
    apiInstance.LoginWithHttpInfo(redirect, postLoginRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.LoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redirect** | **string** | リダイレクト先 | [optional]  |
| **postLoginRequest** | [**PostLoginRequest**](PostLoginRequest.md) |  | [optional]  |

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
| **204** | No Content ログインしました。 |  -  |
| **302** | Found ログインしました。リダイレクトします。 |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized 認証情報が間違っています。 |  -  |
| **403** | Forbidden ログインを試行したユーザーアカウントに問題があります。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="logout"></a>
# **Logout**
> void Logout (string redirect = null, bool all = null)

ログアウト

ログアウトします。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var redirect = "redirect_example";  // string | リダイレクト先 (optional) 
            var all = false;  // bool | 全てのセッションでログアウトするかどうか (optional)  (default to false)

            try
            {
                // ログアウト
                apiInstance.Logout(redirect, all);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ログアウト
    apiInstance.LogoutWithHttpInfo(redirect, all);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.LogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redirect** | **string** | リダイレクト先 | [optional]  |
| **all** | **bool** | 全てのセッションでログアウトするかどうか | [optional] [default to false] |

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
| **204** | No Content ログアウトしました。 |  -  |
| **302** | Found ログアウトしました。リダイレクトします。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="revokemysession"></a>
# **RevokeMySession**
> void RevokeMySession (Guid sessionId)

セッションを無効化

指定した自分のセッションを無効化(ログアウト)します。 既に存在しない・無効化されているセッションを指定した場合も`204`を返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class RevokeMySessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var sessionId = "sessionId_example";  // Guid | セッションUUID

            try
            {
                // セッションを無効化
                apiInstance.RevokeMySession(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.RevokeMySession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokeMySessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // セッションを無効化
    apiInstance.RevokeMySessionWithHttpInfo(sessionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.RevokeMySessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** | セッションUUID |  |

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
| **204** | No Content 無効化しました。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="unlinkexternalaccount"></a>
# **UnlinkExternalAccount**
> void UnlinkExternalAccount (PostUnlinkExternalAccount postUnlinkExternalAccount = null)

外部ログインアカウントの紐付けを解除

自分に紐付けられている外部ログインアカウントの紐付けを解除します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class UnlinkExternalAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var postUnlinkExternalAccount = new PostUnlinkExternalAccount(); // PostUnlinkExternalAccount |  (optional) 

            try
            {
                // 外部ログインアカウントの紐付けを解除
                apiInstance.UnlinkExternalAccount(postUnlinkExternalAccount);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.UnlinkExternalAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkExternalAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部ログインアカウントの紐付けを解除
    apiInstance.UnlinkExternalAccountWithHttpInfo(postUnlinkExternalAccount);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.UnlinkExternalAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postUnlinkExternalAccount** | [**PostUnlinkExternalAccount**](PostUnlinkExternalAccount.md) |  | [optional]  |

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
| **204** | No Content 紐付けを解除しました。 |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

