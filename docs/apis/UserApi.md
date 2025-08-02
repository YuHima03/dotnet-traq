# Traq.Api.UserApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddUserTag**](UserApi.md#addusertag) | **POST** /users/{userId}/tags | ユーザーにタグを追加 |
| [**ChangeUserIcon**](UserApi.md#changeusericon) | **PUT** /users/{userId}/icon | ユーザーのアイコン画像を変更します |
| [**ChangeUserPassword**](UserApi.md#changeuserpassword) | **PUT** /users/{userId}/password | ユーザーのパスワードを変更 |
| [**CreateUser**](UserApi.md#createuser) | **POST** /users | ユーザーを登録 |
| [**EditUser**](UserApi.md#edituser) | **PATCH** /users/{userId} | ユーザー情報を変更 |
| [**EditUserTag**](UserApi.md#editusertag) | **PATCH** /users/{userId}/tags/{tagId} | ユーザーのタグを編集 |
| [**GetDirectMessages**](UserApi.md#getdirectmessages) | **GET** /users/{userId}/messages | ダイレクトメッセージのリストを取得 |
| [**GetUser**](UserApi.md#getuser) | **GET** /users/{userId} | ユーザー詳細情報を取得 |
| [**GetUserDMChannel**](UserApi.md#getuserdmchannel) | **GET** /users/{userId}/dm-channel | DMチャンネル情報を取得 |
| [**GetUserIcon**](UserApi.md#getusericon) | **GET** /users/{userId}/icon | ユーザーのアイコン画像を取得 |
| [**GetUserStats**](UserApi.md#getuserstats) | **GET** /users/{userId}/stats | ユーザー統計情報を取得 |
| [**GetUserTags**](UserApi.md#getusertags) | **GET** /users/{userId}/tags | ユーザーのタグリストを取得 |
| [**GetUsers**](UserApi.md#getusers) | **GET** /users | ユーザーのリストを取得 |
| [**PostDirectMessage**](UserApi.md#postdirectmessage) | **POST** /users/{userId}/messages | ダイレクトメッセージを送信 |
| [**RemoveUserTag**](UserApi.md#removeusertag) | **DELETE** /users/{userId}/tags/{tagId} | ユーザーからタグを削除します |

<a id="addusertag"></a>
# **AddUserTag**
> UserTag AddUserTag (Guid userId, PostUserTagRequest postUserTagRequest = null)

ユーザーにタグを追加

指定したユーザーに指定したタグを追加します。 Webhookユーザーにタグを追加することは出来ません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
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
| **403** | Forbidden |  -  |
| **404** | Not Found ユーザーが見つかりません。 |  -  |
| **409** | Conflict 既に追加されています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeusericon"></a>
# **ChangeUserIcon**
> void ChangeUserIcon (Guid userId, System.IO.Stream file)

ユーザーのアイコン画像を変更します

指定したユーザーのアイコン画像を変更します。 管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
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
| **404** | Not Found ユーザーが見つかりません。 |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeuserpassword"></a>
# **ChangeUserPassword**
> void ChangeUserPassword (Guid userId, PutUserPasswordRequest putUserPasswordRequest = null)

ユーザーのパスワードを変更

指定したユーザーのパスワードを変更します。 管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
| **putUserPasswordRequest** | [**PutUserPasswordRequest**](PutUserPasswordRequest.md) |  | [optional]  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createuser"></a>
# **CreateUser**
> UserDetail CreateUser (PostUserRequest postUserRequest = null)

ユーザーを登録

ユーザーを登録します。 管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postUserRequest** | [**PostUserRequest**](PostUserRequest.md) |  | [optional]  |

### Return type

[**UserDetail**](UserDetail.md)

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
| **403** | Forbidden |  -  |
| **409** | Conflict nameが重複しています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="edituser"></a>
# **EditUser**
> void EditUser (Guid userId, PatchUserRequest patchUserRequest = null)

ユーザー情報を変更

指定したユーザーの情報を変更します。 管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
| **patchUserRequest** | [**PatchUserRequest**](PatchUserRequest.md) |  | [optional]  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editusertag"></a>
# **EditUserTag**
> void EditUserTag (Guid userId, Guid tagId, PatchUserTagRequest patchUserTagRequest = null)

ユーザーのタグを編集

指定したユーザーの指定したタグの状態を変更します。 他人の状態は変更できません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
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
| **404** | Not Found ユーザーか、タグが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdirectmessages"></a>
# **GetDirectMessages**
> List&lt;Message&gt; GetDirectMessages (Guid userId, int limit = null, int offset = null, DateTimeOffset since = null, DateTimeOffset until = null, bool inclusive = null, string order = null)

ダイレクトメッセージのリストを取得

指定したユーザーとのダイレクトメッセージのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
| **limit** | **int** | 取得する件数 | [optional]  |
| **offset** | **int** | 取得するオフセット | [optional] [default to 0] |
| **since** | **DateTimeOffset** | 取得する時間範囲の開始日時 | [optional] [default to &quot;0000-01-01T00:00Z&quot;] |
| **until** | **DateTimeOffset** | 取得する時間範囲の終了日時 | [optional]  |
| **inclusive** | **bool** | 範囲の端を含めるかどうか | [optional] [default to false] |
| **order** | **string** | 昇順か降順か | [optional] [default to desc] |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getuser"></a>
# **GetUser**
> UserDetail GetUser (Guid userId)

ユーザー詳細情報を取得

指定したユーザーの詳細情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |

### Return type

[**UserDetail**](UserDetail.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getuserdmchannel"></a>
# **GetUserDMChannel**
> DMChannel GetUserDMChannel (Guid userId)

DMチャンネル情報を取得

指定したユーザーとのダイレクトメッセージチャンネルの情報を返します。 ダイレクトメッセージチャンネルが存在しなかった場合、自動的に作成されます。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** |  |  |

### Return type

[**DMChannel**](DMChannel.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found ユーザーが見つかりません。  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusericon"></a>
# **GetUserIcon**
> System.IO.Stream GetUserIcon (Guid userId)

ユーザーのアイコン画像を取得

指定したユーザーのアイコン画像を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |

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

<a id="getuserstats"></a>
# **GetUserStats**
> UserStats GetUserStats (Guid userId)

ユーザー統計情報を取得

指定したユーザーの統計情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |

### Return type

[**UserStats**](UserStats.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusertags"></a>
# **GetUserTags**
> List&lt;UserTag&gt; GetUserTags (Guid userId)

ユーザーのタグリストを取得

指定したユーザーのタグリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |

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
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusers"></a>
# **GetUsers**
> List&lt;User&gt; GetUsers (bool includeSuspended = null, string name = null)

ユーザーのリストを取得

ユーザーのリストを取得します。 `include-suspended`を指定しない場合、レスポンスにはユーザーアカウント状態が\"1: 有効\"であるユーザーのみが含まれます。 `include-suspended`と`name`を同時に指定することはできません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeSuspended** | **bool** | アカウントがアクティブでないユーザーを含め、全てのユーザーを取得するかどうか | [optional] [default to false] |
| **name** | **string** | 名前が一致するアカウントのみを取得する | [optional]  |

### Return type

[**List&lt;User&gt;**](User.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postdirectmessage"></a>
# **PostDirectMessage**
> Message PostDirectMessage (Guid userId, PostMessageRequest postMessageRequest = null)

ダイレクトメッセージを送信

指定したユーザーにダイレクトメッセージを送信します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
| **postMessageRequest** | [**PostMessageRequest**](PostMessageRequest.md) |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removeusertag"></a>
# **RemoveUserTag**
> void RemoveUserTag (Guid userId, Guid tagId)

ユーザーからタグを削除します

既に存在しないタグを削除しようとした場合は204を返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | ユーザーUUID |  |
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
| **403** | Forbidden タグがロックされていました。 |  -  |
| **404** | Not Found ユーザーが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

