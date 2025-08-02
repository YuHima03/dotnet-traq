# Traq.Api.Oauth2Api

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateClient**](Oauth2Api.md#createclient) | **POST** /clients | OAuth2クライアントを作成 |
| [**DeleteClient**](Oauth2Api.md#deleteclient) | **DELETE** /clients/{clientId} | OAuth2クライアントを削除 |
| [**EditClient**](Oauth2Api.md#editclient) | **PATCH** /clients/{clientId} | OAuth2クライアント情報を変更 |
| [**GetClient**](Oauth2Api.md#getclient) | **GET** /clients/{clientId} | OAuth2クライアント情報を取得 |
| [**GetClients**](Oauth2Api.md#getclients) | **GET** /clients | OAuth2クライアントのリストを取得 |
| [**GetMyTokens**](Oauth2Api.md#getmytokens) | **GET** /users/me/tokens | 有効トークンのリストを取得 |
| [**GetOAuth2Authorize**](Oauth2Api.md#getoauth2authorize) | **GET** /oauth2/authorize | OAuth2 認可エンドポイント |
| [**PostOAuth2Authorize**](Oauth2Api.md#postoauth2authorize) | **POST** /oauth2/authorize | OAuth2 認可エンドポイント |
| [**PostOAuth2AuthorizeDecide**](Oauth2Api.md#postoauth2authorizedecide) | **POST** /oauth2/authorize/decide | OAuth2 認可承諾API |
| [**PostOAuth2Token**](Oauth2Api.md#postoauth2token) | **POST** /oauth2/token | OAuth2 トークンエンドポイント |
| [**RevokeClientTokens**](Oauth2Api.md#revokeclienttokens) | **DELETE** /clients/{clientId}/tokens | OAuthクライアントのトークンを削除 |
| [**RevokeMyToken**](Oauth2Api.md#revokemytoken) | **DELETE** /users/me/tokens/{tokenId} | トークンの認可を取り消す |
| [**RevokeOAuth2Token**](Oauth2Api.md#revokeoauth2token) | **POST** /oauth2/revoke | OAuth2 トークン無効化エンドポイント |

<a id="createclient"></a>
# **CreateClient**
> OAuth2ClientDetail CreateClient (PostClientRequest postClientRequest = null)

OAuth2クライアントを作成

OAuth2クライアントを作成します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postClientRequest** | [**PostClientRequest**](PostClientRequest.md) |  | [optional]  |

### Return type

[**OAuth2ClientDetail**](OAuth2ClientDetail.md)

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

<a id="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (string clientId)

OAuth2クライアントを削除

指定したOAuth2クライアントを削除します。 対象のクライアントの管理権限が必要です。正常に削除された場合、このクライアントに対する認可は全て取り消されます。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | OAuth2クライアントUUID |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found OAuth2クライアントが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editclient"></a>
# **EditClient**
> void EditClient (string clientId, PatchClientRequest patchClientRequest = null)

OAuth2クライアント情報を変更

指定したOAuth2クライアントの情報を変更します。 対象のクライアントの管理権限が必要です。 クライアント開発者UUIDを変更した場合は、変更先ユーザーにクライアント管理権限が移譲され、自分自身は権限を失います。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | OAuth2クライアントUUID |  |
| **patchClientRequest** | [**PatchClientRequest**](PatchClientRequest.md) |  | [optional]  |

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
| **404** | Not Found OAuth2クライアントが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclient"></a>
# **GetClient**
> GetClient200Response GetClient (string clientId, bool detail = null)

OAuth2クライアント情報を取得

指定したOAuth2クライアントの情報を取得します。 詳細情報の取得には対象のクライアントの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | OAuth2クライアントUUID |  |
| **detail** | **bool** | 詳細情報を含めるかどうか | [optional] [default to false] |

### Return type

[**GetClient200Response**](GetClient200Response.md)

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

<a id="getclients"></a>
# **GetClients**
> List&lt;OAuth2Client&gt; GetClients (bool all = null)

OAuth2クライアントのリストを取得

自身が開発者のOAuth2クライアントのリストを取得します。 `all`が`true`の場合、全開発者の全クライアントのリストを返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **all** | **bool** | 全てのクライアントを取得するかどうか | [optional] [default to false] |

### Return type

[**List&lt;OAuth2Client&gt;**](OAuth2Client.md)

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

<a id="getoauth2authorize"></a>
# **GetOAuth2Authorize**
> void GetOAuth2Authorize (string clientId, OAuth2ResponseType responseType = null, string redirectUri = null, string scope = null, string state = null, string codeChallenge = null, string codeChallengeMethod = null, string nonce = null, OAuth2Prompt prompt = null)

OAuth2 認可エンドポイント

OAuth2 認可エンドポイント


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **responseType** | **OAuth2ResponseType** |  | [optional]  |
| **redirectUri** | **string** |  | [optional]  |
| **scope** | **string** |  | [optional]  |
| **state** | **string** |  | [optional]  |
| **codeChallenge** | **string** |  | [optional]  |
| **codeChallengeMethod** | **string** |  | [optional]  |
| **nonce** | **string** |  | [optional]  |
| **prompt** | **OAuth2Prompt** |  | [optional]  |

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
| **302** | 結果に応じてリダイレクトします。 |  -  |
| **400** | リクエストが不正です。 |  -  |
| **403** | リクエストが許可されていません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postoauth2authorize"></a>
# **PostOAuth2Authorize**
> void PostOAuth2Authorize (string clientId, OAuth2ResponseType responseType = null, string redirectUri = null, string scope = null, string state = null, string codeChallenge = null, string codeChallengeMethod = null, string nonce = null, OAuth2Prompt prompt = null)

OAuth2 認可エンドポイント

OAuth2 認可エンドポイント


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **responseType** | **OAuth2ResponseType** |  | [optional]  |
| **redirectUri** | **string** |  | [optional]  |
| **scope** | **string** |  | [optional]  |
| **state** | **string** |  | [optional]  |
| **codeChallenge** | **string** |  | [optional]  |
| **codeChallengeMethod** | **string** |  | [optional]  |
| **nonce** | **string** |  | [optional]  |
| **prompt** | **OAuth2Prompt** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | 結果に応じてリダイレクトします。 |  -  |
| **400** | リクエストが不正です。 |  -  |
| **403** | リクエストが許可されていません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postoauth2authorizedecide"></a>
# **PostOAuth2AuthorizeDecide**
> void PostOAuth2AuthorizeDecide (string submit)

OAuth2 認可承諾API

OAuth2 認可承諾


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **submit** | **string** | 承諾する場合は\\\&quot;approve\\\&quot; |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | RedirectURIに結果をリダイレクトします。 |  -  |
| **400** | リクエストが不正です。 |  -  |
| **403** | リクエストが許可されていません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postoauth2token"></a>
# **PostOAuth2Token**
> OAuth2Token PostOAuth2Token (string grantType, string code = null, string redirectUri = null, string clientId = null, string codeVerifier = null, string username = null, string password = null, string scope = null, string refreshToken = null, string clientSecret = null)

OAuth2 トークンエンドポイント

OAuth2 トークンエンドポイント


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string** |  |  |
| **code** | **string** |  | [optional]  |
| **redirectUri** | **string** |  | [optional]  |
| **clientId** | **string** |  | [optional]  |
| **codeVerifier** | **string** |  | [optional]  |
| **username** | **string** |  | [optional]  |
| **password** | **string** |  | [optional]  |
| **scope** | **string** |  | [optional]  |
| **refreshToken** | **string** |  | [optional]  |
| **clientSecret** | **string** |  | [optional]  |

### Return type

[**OAuth2Token**](OAuth2Token.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | トークンが正常に発行されました。 |  -  |
| **400** | トークン発行に失敗しました。 |  -  |
| **403** | トークン発行に失敗しました。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="revokeclienttokens"></a>
# **RevokeClientTokens**
> void RevokeClientTokens (string clientId)

OAuthクライアントのトークンを削除

自分が許可している指定したOAuthクライアントのアクセストークンを全てRevokeします。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | OAuth2クライアントUUID |  |

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
| **204** | No Content 削除できました。 |  -  |
| **404** | Not Found OAuth2クライアントが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="revokemytoken"></a>
# **RevokeMyToken**
> void RevokeMyToken (Guid tokenId)

トークンの認可を取り消す

自分の指定したトークンの認可を取り消します。


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

<a id="revokeoauth2token"></a>
# **RevokeOAuth2Token**
> void RevokeOAuth2Token (string token)

OAuth2 トークン無効化エンドポイント

OAuth2 トークン無効化エンドポイント


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | 無効化するOAuth2トークンまたはOAuth2リフレッシュトークン |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

