# Traq.Api.UserTagApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMyUserTag**](UserTagApi.md#addmyusertag) | **POST** /users/me/tags | 自分にタグを追加 |
| [**AddUserTag**](UserTagApi.md#addusertag) | **POST** /users/{userId}/tags | ユーザーにタグを追加 |
| [**EditMyUserTag**](UserTagApi.md#editmyusertag) | **PATCH** /users/me/tags/{tagId} | 自分のタグを編集 |
| [**EditUserTag**](UserTagApi.md#editusertag) | **PATCH** /users/{userId}/tags/{tagId} | ユーザーのタグを編集 |
| [**GetMyUserTags**](UserTagApi.md#getmyusertags) | **GET** /users/me/tags | 自分のタグリストを取得 |
| [**GetTag**](UserTagApi.md#gettag) | **GET** /tags/{tagId} | タグ情報を取得 |
| [**GetUserTags**](UserTagApi.md#getusertags) | **GET** /users/{userId}/tags | ユーザーのタグリストを取得 |
| [**RemoveMyUserTag**](UserTagApi.md#removemyusertag) | **DELETE** /users/me/tags/{tagId} | 自分からタグを削除します |
| [**RemoveUserTag**](UserTagApi.md#removeusertag) | **DELETE** /users/{userId}/tags/{tagId} | ユーザーからタグを削除します |

<a id="addmyusertag"></a>
# **AddMyUserTag**
> UserTag AddMyUserTag (PostUserTagRequest postUserTagRequest = null)

自分にタグを追加

自分に新しくタグを追加します。


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

<a id="editmyusertag"></a>
# **EditMyUserTag**
> void EditMyUserTag (Guid tagId, PatchUserTagRequest patchUserTagRequest = null)

自分のタグを編集

自分の指定したタグの状態を変更します。


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

<a id="getmyusertags"></a>
# **GetMyUserTags**
> List&lt;UserTag&gt; GetMyUserTags ()

自分のタグリストを取得

自分に付けられているタグの配列を取得します。


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

<a id="gettag"></a>
# **GetTag**
> Tag GetTag (Guid tagId)

タグ情報を取得

指定したタグの情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagId** | **Guid** | タグUUID |  |

### Return type

[**Tag**](Tag.md)

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

<a id="removemyusertag"></a>
# **RemoveMyUserTag**
> void RemoveMyUserTag (Guid tagId)

自分からタグを削除します

既に存在しないタグを削除しようとした場合は204を返します。


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

