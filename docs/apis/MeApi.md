# Traq.Api.MeApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMyStar**](MeApi.md#addmystar) | **POST** /users/me/stars | チャンネルをスターに追加 |
| [**AddMyUserTag**](MeApi.md#addmyusertag) | **POST** /users/me/tags | 自分にタグを追加 |
| [**ChangeMyIcon**](MeApi.md#changemyicon) | **PUT** /users/me/icon | 自分のアイコン画像を変更 |
| [**ChangeMyNotifyCitation**](MeApi.md#changemynotifycitation) | **PUT** /users/me/settings/notify-citation | メッセージ引用通知の設定情報を変更 |
| [**ChangeMyPassword**](MeApi.md#changemypassword) | **PUT** /users/me/password | 自分のパスワードを変更 |
| [**EditMe**](MeApi.md#editme) | **PATCH** /users/me | 自分のユーザー情報を変更 |
| [**EditMyUserTag**](MeApi.md#editmyusertag) | **PATCH** /users/me/tags/{tagId} | 自分のタグを編集 |
| [**GetMe**](MeApi.md#getme) | **GET** /users/me | 自分のユーザー詳細を取得 |
| [**GetMyChannelSubscriptions**](MeApi.md#getmychannelsubscriptions) | **GET** /users/me/subscriptions | 自分のチャンネル購読状態を取得 |
| [**GetMyExternalAccounts**](MeApi.md#getmyexternalaccounts) | **GET** /users/me/ex-accounts | 外部ログインアカウント一覧を取得 |
| [**GetMyIcon**](MeApi.md#getmyicon) | **GET** /users/me/icon | 自分のアイコン画像を取得 |
| [**GetMyNotifyCitation**](MeApi.md#getmynotifycitation) | **GET** /users/me/settings/notify-citation | メッセージ引用通知の設定情報を取得 |
| [**GetMyQRCode**](MeApi.md#getmyqrcode) | **GET** /users/me/qr-code | QRコードを取得 |
| [**GetMySessions**](MeApi.md#getmysessions) | **GET** /users/me/sessions | 自分のログインセッションリストを取得 |
| [**GetMyStampHistory**](MeApi.md#getmystamphistory) | **GET** /users/me/stamp-history | スタンプ履歴を取得 |
| [**GetMyStars**](MeApi.md#getmystars) | **GET** /users/me/stars | スターチャンネルリストを取得 |
| [**GetMyTokens**](MeApi.md#getmytokens) | **GET** /users/me/tokens | 有効トークンのリストを取得 |
| [**GetMyUnreadChannels**](MeApi.md#getmyunreadchannels) | **GET** /users/me/unread | 未読チャンネルを取得 |
| [**GetMyUserTags**](MeApi.md#getmyusertags) | **GET** /users/me/tags | 自分のタグリストを取得 |
| [**GetMyViewStates**](MeApi.md#getmyviewstates) | **GET** /users/me/view-states | 自身のチャンネル閲覧状態一覧を取得 |
| [**GetOIDCUserInfo**](MeApi.md#getoidcuserinfo) | **GET** /users/me/oidc | 自分のユーザー詳細を取得 (OIDC UserInfo) |
| [**GetUserSettings**](MeApi.md#getusersettings) | **GET** /users/me/settings | ユーザー設定を取得 |
| [**LinkExternalAccount**](MeApi.md#linkexternalaccount) | **POST** /users/me/ex-accounts/link | 外部ログインアカウントを紐付ける |
| [**ReadChannel**](MeApi.md#readchannel) | **DELETE** /users/me/unread/{channelId} | チャンネルを既読にする |
| [**RegisterFCMDevice**](MeApi.md#registerfcmdevice) | **POST** /users/me/fcm-device | FCMデバイスを登録 |
| [**RemoveMyStar**](MeApi.md#removemystar) | **DELETE** /users/me/stars/{channelId} | チャンネルをスターから削除します |
| [**RemoveMyUserTag**](MeApi.md#removemyusertag) | **DELETE** /users/me/tags/{tagId} | 自分からタグを削除します |
| [**RevokeMySession**](MeApi.md#revokemysession) | **DELETE** /users/me/sessions/{sessionId} | セッションを無効化 |
| [**RevokeMyToken**](MeApi.md#revokemytoken) | **DELETE** /users/me/tokens/{tokenId} | トークンの認可を取り消す |
| [**SetChannelSubscribeLevel**](MeApi.md#setchannelsubscribelevel) | **PUT** /users/me/subscriptions/{channelId} | チャンネル購読レベルを設定 |
| [**UnlinkExternalAccount**](MeApi.md#unlinkexternalaccount) | **POST** /users/me/ex-accounts/unlink | 外部ログインアカウントの紐付けを解除 |

<a id="addmystar"></a>
# **AddMyStar**
> void AddMyStar (PostStarRequest postStarRequest = null)

チャンネルをスターに追加

指定したチャンネルをスターチャンネルに追加します。 スター済みのチャンネルIDを指定した場合、204を返します。 不正なチャンネルIDを指定した場合、400を返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class AddMyStarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var postStarRequest = new PostStarRequest(); // PostStarRequest |  (optional) 

            try
            {
                // チャンネルをスターに追加
                apiInstance.AddMyStar(postStarRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.AddMyStar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMyStarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネルをスターに追加
    apiInstance.AddMyStarWithHttpInfo(postStarRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.AddMyStarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postStarRequest** | [**PostStarRequest**](PostStarRequest.md) |  | [optional]  |

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
| **204** | No Content スターしました。 |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="addmyusertag"></a>
# **AddMyUserTag**
> UserTag AddMyUserTag (PostUserTagRequest postUserTagRequest = null)

自分にタグを追加

自分に新しくタグを追加します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class AddMyUserTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var postUserTagRequest = new PostUserTagRequest(); // PostUserTagRequest |  (optional) 

            try
            {
                // 自分にタグを追加
                UserTag result = apiInstance.AddMyUserTag(postUserTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.AddMyUserTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMyUserTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分にタグを追加
    ApiResponse<UserTag> response = apiInstance.AddMyUserTagWithHttpInfo(postUserTagRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.AddMyUserTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postUserTagRequest** | [**PostUserTagRequest**](PostUserTagRequest.md) |  | [optional]  |

### Return type

[**UserTag**](UserTag.md)

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
| **409** | Conflict 既に追加されています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changemyicon"></a>
# **ChangeMyIcon**
> void ChangeMyIcon (System.IO.Stream file)

自分のアイコン画像を変更

自分のアイコン画像を変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ChangeMyIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | アイコン画像(2MBまでのpng, jpeg, gif)

            try
            {
                // 自分のアイコン画像を変更
                apiInstance.ChangeMyIcon(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.ChangeMyIcon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeMyIconWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のアイコン画像を変更
    apiInstance.ChangeMyIconWithHttpInfo(file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.ChangeMyIconWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changemynotifycitation"></a>
# **ChangeMyNotifyCitation**
> void ChangeMyNotifyCitation (PutNotifyCitationRequest putNotifyCitationRequest = null)

メッセージ引用通知の設定情報を変更

メッセージ引用通知の設定情報を変更します

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ChangeMyNotifyCitationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var putNotifyCitationRequest = new PutNotifyCitationRequest(); // PutNotifyCitationRequest |  (optional) 

            try
            {
                // メッセージ引用通知の設定情報を変更
                apiInstance.ChangeMyNotifyCitation(putNotifyCitationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.ChangeMyNotifyCitation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeMyNotifyCitationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージ引用通知の設定情報を変更
    apiInstance.ChangeMyNotifyCitationWithHttpInfo(putNotifyCitationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.ChangeMyNotifyCitationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **putNotifyCitationRequest** | [**PutNotifyCitationRequest**](PutNotifyCitationRequest.md) |  | [optional]  |

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
| **204** | 変更できました。 |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changemypassword"></a>
# **ChangeMyPassword**
> void ChangeMyPassword (PutMyPasswordRequest putMyPasswordRequest = null)

自分のパスワードを変更

自身のパスワードを変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ChangeMyPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var putMyPasswordRequest = new PutMyPasswordRequest(); // PutMyPasswordRequest |  (optional) 

            try
            {
                // 自分のパスワードを変更
                apiInstance.ChangeMyPassword(putMyPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.ChangeMyPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeMyPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のパスワードを変更
    apiInstance.ChangeMyPasswordWithHttpInfo(putMyPasswordRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.ChangeMyPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **putMyPasswordRequest** | [**PutMyPasswordRequest**](PutMyPasswordRequest.md) |  | [optional]  |

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
| **204** | No Content 変更できました。 |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized 現在のパスワードが違います。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editme"></a>
# **EditMe**
> void EditMe (PatchMeRequest patchMeRequest = null)

自分のユーザー情報を変更

自身のユーザー情報を変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class EditMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var patchMeRequest = new PatchMeRequest(); // PatchMeRequest |  (optional) 

            try
            {
                // 自分のユーザー情報を変更
                apiInstance.EditMe(patchMeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.EditMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のユーザー情報を変更
    apiInstance.EditMeWithHttpInfo(patchMeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.EditMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **patchMeRequest** | [**PatchMeRequest**](PatchMeRequest.md) |  | [optional]  |

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
| **204** | No Content 変更されました。 |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editmyusertag"></a>
# **EditMyUserTag**
> void EditMyUserTag (Guid tagId, PatchUserTagRequest patchUserTagRequest = null)

自分のタグを編集

自分の指定したタグの状態を変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class EditMyUserTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var tagId = "tagId_example";  // Guid | タグUUID
            var patchUserTagRequest = new PatchUserTagRequest(); // PatchUserTagRequest |  (optional) 

            try
            {
                // 自分のタグを編集
                apiInstance.EditMyUserTag(tagId, patchUserTagRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.EditMyUserTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditMyUserTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のタグを編集
    apiInstance.EditMyUserTagWithHttpInfo(tagId, patchUserTagRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.EditMyUserTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagId** | **Guid** | タグUUID |  |
| **patchUserTagRequest** | [**PatchUserTagRequest**](PatchUserTagRequest.md) |  | [optional]  |

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
| **204** | No Content 変更されました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found タグが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getme"></a>
# **GetMe**
> MyUserDetail GetMe ()

自分のユーザー詳細を取得

自身のユーザー詳細情報を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 自分のユーザー詳細を取得
                MyUserDetail result = apiInstance.GetMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のユーザー詳細を取得
    ApiResponse<MyUserDetail> response = apiInstance.GetMeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MyUserDetail**](MyUserDetail.md)

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

<a id="getmychannelsubscriptions"></a>
# **GetMyChannelSubscriptions**
> List&lt;UserSubscribeState&gt; GetMyChannelSubscriptions ()

自分のチャンネル購読状態を取得

自身のチャンネル購読状態を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyChannelSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 自分のチャンネル購読状態を取得
                List<UserSubscribeState> result = apiInstance.GetMyChannelSubscriptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyChannelSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyChannelSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のチャンネル購読状態を取得
    ApiResponse<List<UserSubscribeState>> response = apiInstance.GetMyChannelSubscriptionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyChannelSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserSubscribeState&gt;**](UserSubscribeState.md)

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

            var apiInstance = new MeApi(config);

            try
            {
                // 外部ログインアカウント一覧を取得
                List<ExternalProviderUser> result = apiInstance.GetMyExternalAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyExternalAccounts: " + e.Message);
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
    Debug.Print("Exception when calling MeApi.GetMyExternalAccountsWithHttpInfo: " + e.Message);
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

<a id="getmyicon"></a>
# **GetMyIcon**
> System.IO.Stream GetMyIcon ()

自分のアイコン画像を取得

自分のアイコン画像を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 自分のアイコン画像を取得
                System.IO.Stream result = apiInstance.GetMyIcon();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyIcon: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyIconWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のアイコン画像を取得
    ApiResponse<System.IO.Stream> response = apiInstance.GetMyIconWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyIconWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmynotifycitation"></a>
# **GetMyNotifyCitation**
> GetNotifyCitation GetMyNotifyCitation ()

メッセージ引用通知の設定情報を取得

メッセージ引用通知の設定情報を変更します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyNotifyCitationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // メッセージ引用通知の設定情報を取得
                GetNotifyCitation result = apiInstance.GetMyNotifyCitation();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyNotifyCitation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyNotifyCitationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // メッセージ引用通知の設定情報を取得
    ApiResponse<GetNotifyCitation> response = apiInstance.GetMyNotifyCitationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyNotifyCitationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetNotifyCitation**](GetNotifyCitation.md)

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

<a id="getmyqrcode"></a>
# **GetMyQRCode**
> System.IO.Stream GetMyQRCode (bool token = null)

QRコードを取得

自身のQRコードを取得します。 返されたQRコードまたはトークンは、発行後の5分間のみ有効です

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyQRCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var token = false;  // bool | 画像でなくトークン文字列で返すかどうか (optional)  (default to false)

            try
            {
                // QRコードを取得
                System.IO.Stream result = apiInstance.GetMyQRCode(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyQRCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyQRCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // QRコードを取得
    ApiResponse<System.IO.Stream> response = apiInstance.GetMyQRCodeWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyQRCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **bool** | 画像でなくトークン文字列で返すかどうか | [optional] [default to false] |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, text/plain


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

            var apiInstance = new MeApi(config);

            try
            {
                // 自分のログインセッションリストを取得
                List<LoginSession> result = apiInstance.GetMySessions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMySessions: " + e.Message);
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
    Debug.Print("Exception when calling MeApi.GetMySessionsWithHttpInfo: " + e.Message);
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

<a id="getmystamphistory"></a>
# **GetMyStampHistory**
> List&lt;StampHistoryEntry&gt; GetMyStampHistory (int limit = null)

スタンプ履歴を取得

自分のスタンプ履歴を最大100件まで取得します。 結果は降順で返されます。  このAPIが返すスタンプ履歴は厳密な履歴ではありません。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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

            var apiInstance = new MeApi(config);
            var limit = 100;  // int | 件数 (optional)  (default to 100)

            try
            {
                // スタンプ履歴を取得
                List<StampHistoryEntry> result = apiInstance.GetMyStampHistory(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyStampHistory: " + e.Message);
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
    Debug.Print("Exception when calling MeApi.GetMyStampHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | 件数 | [optional] [default to 100] |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmystars"></a>
# **GetMyStars**
> List&lt;Guid&gt; GetMyStars ()

スターチャンネルリストを取得

自分がスターしているチャンネルのUUIDの配列を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyStarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // スターチャンネルリストを取得
                List<Guid> result = apiInstance.GetMyStars();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyStars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyStarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // スターチャンネルリストを取得
    ApiResponse<List<Guid>> response = apiInstance.GetMyStarsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyStarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<Guid>**

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

<a id="getmytokens"></a>
# **GetMyTokens**
> List&lt;ActiveOAuth2Token&gt; GetMyTokens ()

有効トークンのリストを取得

有効な自分に発行されたOAuth2トークンのリストを取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 有効トークンのリストを取得
                List<ActiveOAuth2Token> result = apiInstance.GetMyTokens();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 有効トークンのリストを取得
    ApiResponse<List<ActiveOAuth2Token>> response = apiInstance.GetMyTokensWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ActiveOAuth2Token&gt;**](ActiveOAuth2Token.md)

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

<a id="getmyunreadchannels"></a>
# **GetMyUnreadChannels**
> List&lt;UnreadChannel&gt; GetMyUnreadChannels ()

未読チャンネルを取得

自分が現在未読のチャンネルの未読情報を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyUnreadChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 未読チャンネルを取得
                List<UnreadChannel> result = apiInstance.GetMyUnreadChannels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyUnreadChannels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyUnreadChannelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 未読チャンネルを取得
    ApiResponse<List<UnreadChannel>> response = apiInstance.GetMyUnreadChannelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyUnreadChannelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UnreadChannel&gt;**](UnreadChannel.md)

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

<a id="getmyusertags"></a>
# **GetMyUserTags**
> List&lt;UserTag&gt; GetMyUserTags ()

自分のタグリストを取得

自分に付けられているタグの配列を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyUserTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 自分のタグリストを取得
                List<UserTag> result = apiInstance.GetMyUserTags();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyUserTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyUserTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のタグリストを取得
    ApiResponse<List<UserTag>> response = apiInstance.GetMyUserTagsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyUserTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserTag&gt;**](UserTag.md)

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

<a id="getmyviewstates"></a>
# **GetMyViewStates**
> List&lt;MyChannelViewState&gt; GetMyViewStates ()

自身のチャンネル閲覧状態一覧を取得

自身のチャンネル閲覧状態一覧を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetMyViewStatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 自身のチャンネル閲覧状態一覧を取得
                List<MyChannelViewState> result = apiInstance.GetMyViewStates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetMyViewStates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyViewStatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自身のチャンネル閲覧状態一覧を取得
    ApiResponse<List<MyChannelViewState>> response = apiInstance.GetMyViewStatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetMyViewStatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;MyChannelViewState&gt;**](MyChannelViewState.md)

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

<a id="getoidcuserinfo"></a>
# **GetOIDCUserInfo**
> OIDCUserInfo GetOIDCUserInfo ()

自分のユーザー詳細を取得 (OIDC UserInfo)

OIDCトークンを用いてユーザー詳細を取得します。 OIDC UserInfo Endpointです。 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetOIDCUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // 自分のユーザー詳細を取得 (OIDC UserInfo)
                OIDCUserInfo result = apiInstance.GetOIDCUserInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetOIDCUserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOIDCUserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のユーザー詳細を取得 (OIDC UserInfo)
    ApiResponse<OIDCUserInfo> response = apiInstance.GetOIDCUserInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetOIDCUserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OIDCUserInfo**](OIDCUserInfo.md)

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

<a id="getusersettings"></a>
# **GetUserSettings**
> UserSettings GetUserSettings ()

ユーザー設定を取得

ユーザー設定を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class GetUserSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);

            try
            {
                // ユーザー設定を取得
                UserSettings result = apiInstance.GetUserSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.GetUserSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ユーザー設定を取得
    ApiResponse<UserSettings> response = apiInstance.GetUserSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.GetUserSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSettings**](UserSettings.md)

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

            var apiInstance = new MeApi(config);
            var postLinkExternalAccount = new PostLinkExternalAccount(); // PostLinkExternalAccount |  (optional) 

            try
            {
                // 外部ログインアカウントを紐付ける
                apiInstance.LinkExternalAccount(postLinkExternalAccount);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.LinkExternalAccount: " + e.Message);
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
    Debug.Print("Exception when calling MeApi.LinkExternalAccountWithHttpInfo: " + e.Message);
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

<a id="readchannel"></a>
# **ReadChannel**
> void ReadChannel (Guid channelId)

チャンネルを既読にする

自分が未読のチャンネルを既読にします。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class ReadChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var channelId = "channelId_example";  // Guid | チャンネルUUID

            try
            {
                // チャンネルを既読にする
                apiInstance.ReadChannel(channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.ReadChannel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadChannelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネルを既読にする
    apiInstance.ReadChannelWithHttpInfo(channelId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.ReadChannelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

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
| **204** | No Content 既読にしました。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="registerfcmdevice"></a>
# **RegisterFCMDevice**
> void RegisterFCMDevice (PostMyFCMDeviceRequest postMyFCMDeviceRequest = null)

FCMデバイスを登録

自身のFCMデバイスを登録します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class RegisterFCMDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var postMyFCMDeviceRequest = new PostMyFCMDeviceRequest(); // PostMyFCMDeviceRequest |  (optional) 

            try
            {
                // FCMデバイスを登録
                apiInstance.RegisterFCMDevice(postMyFCMDeviceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.RegisterFCMDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterFCMDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FCMデバイスを登録
    apiInstance.RegisterFCMDeviceWithHttpInfo(postMyFCMDeviceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.RegisterFCMDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postMyFCMDeviceRequest** | [**PostMyFCMDeviceRequest**](PostMyFCMDeviceRequest.md) |  | [optional]  |

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
| **204** | No Content 登録できました。 |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removemystar"></a>
# **RemoveMyStar**
> void RemoveMyStar (Guid channelId)

チャンネルをスターから削除します

既にスターから削除されているチャンネルを指定した場合は204を返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class RemoveMyStarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var channelId = "channelId_example";  // Guid | チャンネルUUID

            try
            {
                // チャンネルをスターから削除します
                apiInstance.RemoveMyStar(channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.RemoveMyStar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMyStarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネルをスターから削除します
    apiInstance.RemoveMyStarWithHttpInfo(channelId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.RemoveMyStarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removemyusertag"></a>
# **RemoveMyUserTag**
> void RemoveMyUserTag (Guid tagId)

自分からタグを削除します

既に存在しないタグを削除しようとした場合は204を返します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class RemoveMyUserTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var tagId = "tagId_example";  // Guid | タグUUID

            try
            {
                // 自分からタグを削除します
                apiInstance.RemoveMyUserTag(tagId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.RemoveMyUserTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMyUserTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分からタグを削除します
    apiInstance.RemoveMyUserTagWithHttpInfo(tagId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.RemoveMyUserTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagId** | **Guid** | タグUUID |  |

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
| **403** | Forbidden タグがロックされています。 |  -  |

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

            var apiInstance = new MeApi(config);
            var sessionId = "sessionId_example";  // Guid | セッションUUID

            try
            {
                // セッションを無効化
                apiInstance.RevokeMySession(sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.RevokeMySession: " + e.Message);
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
    Debug.Print("Exception when calling MeApi.RevokeMySessionWithHttpInfo: " + e.Message);
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

<a id="revokemytoken"></a>
# **RevokeMyToken**
> void RevokeMyToken (Guid tokenId)

トークンの認可を取り消す

自分の指定したトークンの認可を取り消します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class RevokeMyTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var tokenId = "tokenId_example";  // Guid | OAuth2トークンUUID

            try
            {
                // トークンの認可を取り消す
                apiInstance.RevokeMyToken(tokenId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.RevokeMyToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokeMyTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // トークンの認可を取り消す
    apiInstance.RevokeMyTokenWithHttpInfo(tokenId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.RevokeMyTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenId** | **Guid** | OAuth2トークンUUID |  |

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
| **204** | No Content 取り消しました。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="setchannelsubscribelevel"></a>
# **SetChannelSubscribeLevel**
> void SetChannelSubscribeLevel (Guid channelId, PutChannelSubscribeLevelRequest putChannelSubscribeLevelRequest = null)

チャンネル購読レベルを設定

自身の指定したチャンネルの購読レベルを設定します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Traq.Api;
using Traq.Client;
using Traq.Model;

namespace Example
{
    public class SetChannelSubscribeLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://q.trap.jp/api/v3";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MeApi(config);
            var channelId = "channelId_example";  // Guid | チャンネルUUID
            var putChannelSubscribeLevelRequest = new PutChannelSubscribeLevelRequest(); // PutChannelSubscribeLevelRequest |  (optional) 

            try
            {
                // チャンネル購読レベルを設定
                apiInstance.SetChannelSubscribeLevel(channelId, putChannelSubscribeLevelRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.SetChannelSubscribeLevel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetChannelSubscribeLevelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // チャンネル購読レベルを設定
    apiInstance.SetChannelSubscribeLevelWithHttpInfo(channelId, putChannelSubscribeLevelRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.SetChannelSubscribeLevelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **putChannelSubscribeLevelRequest** | [**PutChannelSubscribeLevelRequest**](PutChannelSubscribeLevelRequest.md) |  | [optional]  |

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
| **204** | No Content 変更されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden 指定したチャンネルの通知購読レベルは変更できません。 |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

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

            var apiInstance = new MeApi(config);
            var postUnlinkExternalAccount = new PostUnlinkExternalAccount(); // PostUnlinkExternalAccount |  (optional) 

            try
            {
                // 外部ログインアカウントの紐付けを解除
                apiInstance.UnlinkExternalAccount(postUnlinkExternalAccount);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.UnlinkExternalAccount: " + e.Message);
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
    Debug.Print("Exception when calling MeApi.UnlinkExternalAccountWithHttpInfo: " + e.Message);
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

