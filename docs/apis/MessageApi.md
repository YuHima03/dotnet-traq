# Traq.Api.MessageApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMessageStamp**](MessageApi.md#addmessagestamp) | **POST** /messages/{messageId}/stamps/{stampId} | スタンプを押す |
| [**CreatePin**](MessageApi.md#createpin) | **POST** /messages/{messageId}/pin | ピン留めする |
| [**DeleteMessage**](MessageApi.md#deletemessage) | **DELETE** /messages/{messageId} | メッセージを削除 |
| [**EditMessage**](MessageApi.md#editmessage) | **PUT** /messages/{messageId} | メッセージを編集 |
| [**GetDirectMessages**](MessageApi.md#getdirectmessages) | **GET** /users/{userId}/messages | ダイレクトメッセージのリストを取得 |
| [**GetMessage**](MessageApi.md#getmessage) | **GET** /messages/{messageId} | メッセージを取得 |
| [**GetMessageClips**](MessageApi.md#getmessageclips) | **GET** /messages/{messageId}/clips | 自分のクリップを取得 |
| [**GetMessageStamps**](MessageApi.md#getmessagestamps) | **GET** /messages/{messageId}/stamps | メッセージのスタンプリストを取得 |
| [**GetMessages**](MessageApi.md#getmessages) | **GET** /channels/{channelId}/messages | チャンネルメッセージのリストを取得 |
| [**GetPin**](MessageApi.md#getpin) | **GET** /messages/{messageId}/pin | ピン留めを取得 |
| [**PostDirectMessage**](MessageApi.md#postdirectmessage) | **POST** /users/{userId}/messages | ダイレクトメッセージを送信 |
| [**PostMessage**](MessageApi.md#postmessage) | **POST** /channels/{channelId}/messages | チャンネルにメッセージを投稿 |
| [**RemoveMessageStamp**](MessageApi.md#removemessagestamp) | **DELETE** /messages/{messageId}/stamps/{stampId} | スタンプを消す |
| [**RemovePin**](MessageApi.md#removepin) | **DELETE** /messages/{messageId}/pin | ピン留めを外す |
| [**SearchMessages**](MessageApi.md#searchmessages) | **GET** /messages | メッセージを検索 |

<a id="addmessagestamp"></a>
# **AddMessageStamp**
> void AddMessageStamp (Guid messageId, Guid stampId, PostMessageStampRequest postMessageStampRequest = null)

スタンプを押す

指定したメッセージに指定したスタンプを押します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |
| **stampId** | **Guid** | スタンプUUID |  |
| **postMessageStampRequest** | [**PostMessageStampRequest**](PostMessageStampRequest.md) |  | [optional]  |

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
| **204** | No Content スタンプを押すことができました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found メッセージ、またはスタンプが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createpin"></a>
# **CreatePin**
> MessagePin CreatePin (Guid messageId)

ピン留めする

指定したメッセージをピン留めします。 アーカイブされているチャンネルのメッセージ・存在しないメッセージ・チャンネル当たりの上限数を超えたメッセージのピン留めはできません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**MessagePin**](MessagePin.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created 指定したメッセージがピン留めされました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found メッセージが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletemessage"></a>
# **DeleteMessage**
> void DeleteMessage (Guid messageId)

メッセージを削除

指定したメッセージを削除します。 自身が投稿したメッセージと自身が管理権限を持つWebhookとBOTが投稿したメッセージのみ削除することができます。 アーカイブされているチャンネルのメッセージを編集することは出来ません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

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
| **204** | No Content 正常に削除できました。 |  -  |
| **403** | Forbidden 指定されたメッセージを削除する権限がありません。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editmessage"></a>
# **EditMessage**
> void EditMessage (Guid messageId, PostMessageRequest postMessageRequest = null)

メッセージを編集

指定したメッセージを編集します。 自身が投稿したメッセージのみ編集することができます。 アーカイブされているチャンネルのメッセージを編集することは出来ません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |
| **postMessageRequest** | [**PostMessageRequest**](PostMessageRequest.md) |  | [optional]  |

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
| **204** | No Content メッセージを編集できました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden 指定されたメッセージを編集する権限がありません。 |  -  |
| **404** | Not Found |  -  |

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

<a id="getmessage"></a>
# **GetMessage**
> Message GetMessage (Guid messageId)

メッセージを取得

指定したメッセージを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**Message**](Message.md)

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

<a id="getmessageclips"></a>
# **GetMessageClips**
> List&lt;MessageClip&gt; GetMessageClips (Guid messageId)

自分のクリップを取得

対象のメッセージの自分のクリップの一覧を返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**List&lt;MessageClip&gt;**](MessageClip.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmessagestamps"></a>
# **GetMessageStamps**
> List&lt;MessageStamp&gt; GetMessageStamps (Guid messageId)

メッセージのスタンプリストを取得

指定したメッセージに押されているスタンプのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**List&lt;MessageStamp&gt;**](MessageStamp.md)

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

<a id="getmessages"></a>
# **GetMessages**
> List&lt;Message&gt; GetMessages (Guid channelId, int limit = null, int offset = null, DateTimeOffset since = null, DateTimeOffset until = null, bool inclusive = null, string order = null)

チャンネルメッセージのリストを取得

指定したチャンネルのメッセージのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
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
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpin"></a>
# **GetPin**
> MessagePin GetPin (Guid messageId)

ピン留めを取得

指定したメッセージのピン留め情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

### Return type

[**MessagePin**](MessagePin.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found 指定したメッセージ、またはピン留めが見つかりません。 |  -  |

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

<a id="postmessage"></a>
# **PostMessage**
> Message PostMessage (Guid channelId, PostMessageRequest postMessageRequest = null)

チャンネルにメッセージを投稿

指定したチャンネルにメッセージを投稿します。 embedをtrueに指定すると、メッセージ埋め込みが自動で行われます。 アーカイブされているチャンネルに投稿することはできません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
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
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removemessagestamp"></a>
# **RemoveMessageStamp**
> void RemoveMessageStamp (Guid messageId, Guid stampId)

スタンプを消す

指定したメッセージから指定した自身が押したスタンプを削除します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |
| **stampId** | **Guid** | スタンプUUID |  |

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
| **204** | No Content スタンプを消すことができました。 |  -  |
| **404** | Not Found メッセージ、またはスタンプが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removepin"></a>
# **RemovePin**
> void RemovePin (Guid messageId)

ピン留めを外す

指定したメッセージのピン留めを外します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | メッセージUUID |  |

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
| **204** | No Content 指定したメッセージのピン留めが外されました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found 指定したメッセージ、またはピン留めが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchmessages"></a>
# **SearchMessages**
> MessageSearchResult SearchMessages (string word = null, DateTimeOffset after = null, DateTimeOffset before = null, Guid varIn = null, List<Guid> to = null, List<Guid> from = null, Guid citation = null, bool bot = null, bool hasURL = null, bool hasAttachments = null, bool hasImage = null, bool hasVideo = null, bool hasAudio = null, int limit = null, int offset = null, string sort = null)

メッセージを検索

メッセージを検索します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **word** | **string** | 検索ワード Simple-Query-String-Syntaxをパースして検索します  | [optional]  |
| **after** | **DateTimeOffset** | 投稿日時が指定日時より後 | [optional]  |
| **before** | **DateTimeOffset** | 投稿日時が指定日時より前 | [optional]  |
| **varIn** | **Guid** | メッセージが投稿されたチャンネル | [optional]  |
| **to** | [**List&lt;Guid&gt;**](Guid.md) | メンションされたユーザー | [optional]  |
| **from** | [**List&lt;Guid&gt;**](Guid.md) | メッセージを投稿したユーザー | [optional]  |
| **citation** | **Guid** | 引用しているメッセージ | [optional]  |
| **bot** | **bool** | メッセージを投稿したユーザーがBotかどうか | [optional]  |
| **hasURL** | **bool** | メッセージがURLを含むか | [optional]  |
| **hasAttachments** | **bool** | メッセージが添付ファイルを含むか | [optional]  |
| **hasImage** | **bool** | メッセージが画像を含むか | [optional]  |
| **hasVideo** | **bool** | メッセージが動画を含むか | [optional]  |
| **hasAudio** | **bool** | メッセージが音声ファイルを含むか | [optional]  |
| **limit** | **int** | 検索結果から取得するメッセージの最大件数 | [optional]  |
| **offset** | **int** | 検索結果から取得するメッセージのオフセット | [optional]  |
| **sort** | **string** | ソート順 (作成日時が新しい &#x60;createdAt&#x60;, 作成日時が古い &#x60;-createdAt&#x60;, 更新日時が新しい &#x60;updatedAt&#x60;, 更新日時が古い &#x60;-updatedAt&#x60;) | [optional] [default to -createdAt] |

### Return type

[**MessageSearchResult**](MessageSearchResult.md)

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
| **503** | search service is currently unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

