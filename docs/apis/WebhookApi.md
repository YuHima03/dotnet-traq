# Traq.Api.WebhookApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeWebhookIcon**](WebhookApi.md#changewebhookicon) | **PUT** /webhooks/{webhookId}/icon | Webhookのアイコンを変更 |
| [**CreateWebhook**](WebhookApi.md#createwebhook) | **POST** /webhooks | Webhookを新規作成 |
| [**DeleteWebhook**](WebhookApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Webhookを削除 |
| [**EditWebhook**](WebhookApi.md#editwebhook) | **PATCH** /webhooks/{webhookId} | Webhook情報を変更 |
| [**GetWebhook**](WebhookApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Webhook情報を取得 |
| [**GetWebhookIcon**](WebhookApi.md#getwebhookicon) | **GET** /webhooks/{webhookId}/icon | Webhookのアイコンを取得 |
| [**GetWebhookMessages**](WebhookApi.md#getwebhookmessages) | **GET** /webhooks/{webhookId}/messages | Webhookの投稿メッセージのリストを取得 |
| [**GetWebhooks**](WebhookApi.md#getwebhooks) | **GET** /webhooks | Webhook情報のリストを取得します |
| [**PostWebhook**](WebhookApi.md#postwebhook) | **POST** /webhooks/{webhookId} | Webhookを送信 |

<a id="changewebhookicon"></a>
# **ChangeWebhookIcon**
> void ChangeWebhookIcon (Guid webhookId, System.IO.Stream file)

Webhookのアイコンを変更

指定したWebhookのアイコン画像を変更します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
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
| **404** | Not Found Webhookが見つかりません。 |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createwebhook"></a>
# **CreateWebhook**
> Webhook CreateWebhook (PostWebhookRequest postWebhookRequest = null)

Webhookを新規作成

Webhookを新規作成します。 `secret`が空文字の場合、insecureウェブフックが作成されます。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postWebhookRequest** | [**PostWebhookRequest**](PostWebhookRequest.md) |  | [optional]  |

### Return type

[**Webhook**](Webhook.md)

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

<a id="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (Guid webhookId)

Webhookを削除

指定したWebhookを削除します。 Webhookによって投稿されたメッセージは削除されません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |

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
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editwebhook"></a>
# **EditWebhook**
> void EditWebhook (Guid webhookId, PatchWebhookRequest patchWebhookRequest = null)

Webhook情報を変更

指定したWebhookの情報を変更します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
| **patchWebhookRequest** | [**PatchWebhookRequest**](PatchWebhookRequest.md) |  | [optional]  |

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
| **204** | No Content 編集できました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (Guid webhookId)

Webhook情報を取得

指定したWebhookの詳細を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhookicon"></a>
# **GetWebhookIcon**
> System.IO.Stream GetWebhookIcon (Guid webhookId)

Webhookのアイコンを取得

指定したWebhookのアイコン画像を取得します


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |

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
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhookmessages"></a>
# **GetWebhookMessages**
> List&lt;Message&gt; GetWebhookMessages (Guid webhookId, int limit = null, int offset = null, DateTimeOffset since = null, DateTimeOffset until = null, bool inclusive = null, string order = null)

Webhookの投稿メッセージのリストを取得

指定されたWebhookが投稿したメッセージのリストを返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
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
| **404** | Not Found Webhookが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhooks"></a>
# **GetWebhooks**
> List&lt;Webhook&gt; GetWebhooks (bool all = null)

Webhook情報のリストを取得します

Webhookのリストを取得します。 allがtrueで無い場合は、自分がオーナーのWebhookのリストを返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **all** | **bool** | 全てのWebhookを取得します。権限が必要です。 | [optional] [default to false] |

### Return type

[**List&lt;Webhook&gt;**](Webhook.md)

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

<a id="postwebhook"></a>
# **PostWebhook**
> void PostWebhook (Guid webhookId, string xTRAQSignature = null, string xTRAQChannelId = null, int embed = null, string body = null)

Webhookを送信

Webhookにメッセージを投稿します。 secureなウェブフックに対しては`X-TRAQ-Signature`ヘッダーが必須です。 アーカイブされているチャンネルには投稿できません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** | WebhookUUID |  |
| **xTRAQSignature** | **string** | リクエストボディシグネチャ(Secretが設定されている場合は必須) | [optional]  |
| **xTRAQChannelId** | **string** | 投稿先のチャンネルID(変更する場合) | [optional]  |
| **embed** | **int** | メンション・チャンネルリンクを自動埋め込みする場合に1を指定する | [optional] [default to 0] |
| **body** | **string** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

