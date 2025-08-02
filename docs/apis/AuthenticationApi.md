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

