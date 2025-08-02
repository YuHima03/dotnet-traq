# Traq.Api.GroupApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddUserGroupAdmin**](GroupApi.md#addusergroupadmin) | **POST** /groups/{groupId}/admins | グループ管理者を追加 |
| [**AddUserGroupMember**](GroupApi.md#addusergroupmember) | **POST** /groups/{groupId}/members | グループメンバーを追加 |
| [**ChangeUserGroupIcon**](GroupApi.md#changeusergroupicon) | **PUT** /groups/{groupId}/icon | ユーザーグループのアイコンを変更 |
| [**CreateUserGroup**](GroupApi.md#createusergroup) | **POST** /groups | ユーザーグループを作成 |
| [**DeleteUserGroup**](GroupApi.md#deleteusergroup) | **DELETE** /groups/{groupId} | ユーザーグループを削除 |
| [**EditUserGroup**](GroupApi.md#editusergroup) | **PATCH** /groups/{groupId} | ユーザーグループを編集 |
| [**EditUserGroupMember**](GroupApi.md#editusergroupmember) | **PATCH** /groups/{groupId}/members/{userId} | グループメンバーを編集 |
| [**GetUserGroup**](GroupApi.md#getusergroup) | **GET** /groups/{groupId} | ユーザーグループを取得 |
| [**GetUserGroupAdmins**](GroupApi.md#getusergroupadmins) | **GET** /groups/{groupId}/admins | グループ管理者を取得 |
| [**GetUserGroupMembers**](GroupApi.md#getusergroupmembers) | **GET** /groups/{groupId}/members | グループメンバーを取得 |
| [**GetUserGroups**](GroupApi.md#getusergroups) | **GET** /groups | ユーザーグループのリストを取得 |
| [**RemoveUserGroupAdmin**](GroupApi.md#removeusergroupadmin) | **DELETE** /groups/{groupId}/admins/{userId} | グループ管理者を削除 |
| [**RemoveUserGroupMember**](GroupApi.md#removeusergroupmember) | **DELETE** /groups/{groupId}/members/{userId} | グループメンバーを削除 |
| [**RemoveUserGroupMembers**](GroupApi.md#removeusergroupmembers) | **DELETE** /groups/{groupId}/members | グループメンバーを一括削除 |

<a id="addusergroupadmin"></a>
# **AddUserGroupAdmin**
> void AddUserGroupAdmin (Guid groupId, PostUserGroupAdminRequest postUserGroupAdminRequest = null)

グループ管理者を追加

指定したグループに管理者を追加します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
| **postUserGroupAdminRequest** | [**PostUserGroupAdminRequest**](PostUserGroupAdminRequest.md) |  | [optional]  |

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
| **204** | No Content 追加されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="addusergroupmember"></a>
# **AddUserGroupMember**
> void AddUserGroupMember (Guid groupId, AddUserGroupMemberRequest addUserGroupMemberRequest = null)

グループメンバーを追加

指定したグループにメンバーを追加します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
| **addUserGroupMemberRequest** | [**AddUserGroupMemberRequest**](AddUserGroupMemberRequest.md) |  | [optional]  |

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
| **204** | No Content 追加されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeusergroupicon"></a>
# **ChangeUserGroupIcon**
> void ChangeUserGroupIcon (Guid groupId, System.IO.Stream file)

ユーザーグループのアイコンを変更

ユーザーグループのアイコンを変更します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
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
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createusergroup"></a>
# **CreateUserGroup**
> UserGroup CreateUserGroup (PostUserGroupRequest postUserGroupRequest = null)

ユーザーグループを作成

ユーザーグループを作成します。 作成者は自動的にグループ管理者になります。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postUserGroupRequest** | [**PostUserGroupRequest**](PostUserGroupRequest.md) |  | [optional]  |

### Return type

[**UserGroup**](UserGroup.md)

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
| **403** | Forbidden 指定したグループを作成する権限がありません。 |  -  |
| **409** | Conflict 指定した名前のグループは既に存在します。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteusergroup"></a>
# **DeleteUserGroup**
> void DeleteUserGroup (Guid groupId)

ユーザーグループを削除

指定したユーザーグループを削除します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |

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
| **204** | No Content ユーザーグループが削除されました。 |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editusergroup"></a>
# **EditUserGroup**
> void EditUserGroup (Guid groupId, PatchUserGroupRequest patchUserGroupRequest = null)

ユーザーグループを編集

指定したユーザーグループの情報を編集します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
| **patchUserGroupRequest** | [**PatchUserGroupRequest**](PatchUserGroupRequest.md) |  | [optional]  |

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
| **204** | No Content 編集されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict 変更後のグループ名のグループは既に存在します。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editusergroupmember"></a>
# **EditUserGroupMember**
> void EditUserGroupMember (Guid groupId, Guid userId, PatchGroupMemberRequest patchGroupMemberRequest = null)

グループメンバーを編集

指定したユーザーグループ内の指定したユーザーの属性を編集します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
| **userId** | **Guid** | ユーザーUUID |  |
| **patchGroupMemberRequest** | [**PatchGroupMemberRequest**](PatchGroupMemberRequest.md) |  | [optional]  |

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
| **400** | Bad Request ユーザーがグループに存在しないか、リクエストが不正です。 |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusergroup"></a>
# **GetUserGroup**
> UserGroup GetUserGroup (Guid groupId)

ユーザーグループを取得

指定したユーザーグループの情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |

### Return type

[**UserGroup**](UserGroup.md)

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

<a id="getusergroupadmins"></a>
# **GetUserGroupAdmins**
> List&lt;Guid&gt; GetUserGroupAdmins (Guid groupId)

グループ管理者を取得

指定したグループの管理者のリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |

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
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusergroupmembers"></a>
# **GetUserGroupMembers**
> List&lt;UserGroupMember&gt; GetUserGroupMembers (Guid groupId)

グループメンバーを取得

指定したグループのメンバーのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |

### Return type

[**List&lt;UserGroupMember&gt;**](UserGroupMember.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusergroups"></a>
# **GetUserGroups**
> List&lt;UserGroup&gt; GetUserGroups ()

ユーザーグループのリストを取得

ユーザーグループのリストを取得します。


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserGroup&gt;**](UserGroup.md)

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

<a id="removeusergroupadmin"></a>
# **RemoveUserGroupAdmin**
> void RemoveUserGroupAdmin (Guid groupId, Guid userId)

グループ管理者を削除

指定したユーザーグループから指定した管理者を削除します。 対象のユーザーグループの管理者権限が必要です。 グループから管理者が存在しなくなる場合は400エラーを返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
| **userId** | **Guid** | ユーザーUUID |  |

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
| **204** | No Content 指定したユーザーがユーザーグループ管理者から削除されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removeusergroupmember"></a>
# **RemoveUserGroupMember**
> void RemoveUserGroupMember (Guid groupId, Guid userId)

グループメンバーを削除

指定したユーザーグループから指定したユーザーを削除します。 既にグループから削除されているメンバーを指定した場合は204を返します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |
| **userId** | **Guid** | ユーザーUUID |  |

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
| **204** | No Content 指定したユーザーがユーザーグループから削除されました。 |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removeusergroupmembers"></a>
# **RemoveUserGroupMembers**
> void RemoveUserGroupMembers (Guid groupId)

グループメンバーを一括削除

指定したグループから全てのメンバーを削除します。 対象のユーザーグループの管理者権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | ユーザーグループUUID |  |

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
| **204** | No Content グループから全てのユーザーが削除されました。 |  -  |
| **403** | Forbidden ユーザーグループを操作する権限がありません。 |  -  |
| **404** | Not Found ユーザーグループが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

