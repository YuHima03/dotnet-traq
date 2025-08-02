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

