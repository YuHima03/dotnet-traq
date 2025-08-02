# Traq.Api.ChannelApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateChannel**](ChannelApi.md#createchannel) | **POST** /channels | チャンネルを作成 |
| [**EditChannel**](ChannelApi.md#editchannel) | **PATCH** /channels/{channelId} | チャンネル情報を変更 |
| [**EditChannelSubscribers**](ChannelApi.md#editchannelsubscribers) | **PATCH** /channels/{channelId}/subscribers | チャンネルの通知購読者を編集 |
| [**EditChannelTopic**](ChannelApi.md#editchanneltopic) | **PUT** /channels/{channelId}/topic | チャンネルトピックを編集 |
| [**GetChannel**](ChannelApi.md#getchannel) | **GET** /channels/{channelId} | チャンネル情報を取得 |
| [**GetChannelBots**](ChannelApi.md#getchannelbots) | **GET** /channels/{channelId}/bots | チャンネル参加中のBOTのリストを取得 |
| [**GetChannelEvents**](ChannelApi.md#getchannelevents) | **GET** /channels/{channelId}/events | チャンネルイベントのリストを取得 |
| [**GetChannelPath**](ChannelApi.md#getchannelpath) | **GET** /channels/{channelId}/path | 指定したチャンネルパスを取得 |
| [**GetChannelPins**](ChannelApi.md#getchannelpins) | **GET** /channels/{channelId}/pins | チャンネルピンのリストを取得 |
| [**GetChannelStats**](ChannelApi.md#getchannelstats) | **GET** /channels/{channelId}/stats | チャンネル統計情報を取得 |
| [**GetChannelSubscribers**](ChannelApi.md#getchannelsubscribers) | **GET** /channels/{channelId}/subscribers | チャンネルの通知購読者のリストを取得 |
| [**GetChannelTopic**](ChannelApi.md#getchanneltopic) | **GET** /channels/{channelId}/topic | チャンネルトピックを取得 |
| [**GetChannelViewers**](ChannelApi.md#getchannelviewers) | **GET** /channels/{channelId}/viewers | チャンネル閲覧者リストを取得 |
| [**GetChannels**](ChannelApi.md#getchannels) | **GET** /channels | チャンネルリストを取得 |
| [**GetMessages**](ChannelApi.md#getmessages) | **GET** /channels/{channelId}/messages | チャンネルメッセージのリストを取得 |
| [**GetUserDMChannel**](ChannelApi.md#getuserdmchannel) | **GET** /users/{userId}/dm-channel | DMチャンネル情報を取得 |
| [**PostMessage**](ChannelApi.md#postmessage) | **POST** /channels/{channelId}/messages | チャンネルにメッセージを投稿 |
| [**SetChannelSubscribers**](ChannelApi.md#setchannelsubscribers) | **PUT** /channels/{channelId}/subscribers | チャンネルの通知購読者を設定 |

<a id="createchannel"></a>
# **CreateChannel**
> Channel CreateChannel (PostChannelRequest postChannelRequest = null)

チャンネルを作成

チャンネルを作成します。 階層が6以上になるチャンネルは作成できません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postChannelRequest** | [**PostChannelRequest**](PostChannelRequest.md) |  | [optional]  |

### Return type

[**Channel**](Channel.md)

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
| **409** | Conflict 指定した名前のチャンネルは既に存在しています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editchannel"></a>
# **EditChannel**
> void EditChannel (Guid channelId, PatchChannelRequest patchChannelRequest = null)

チャンネル情報を変更

指定したチャンネルの情報を変更します。 変更には権限が必要です。 ルートチャンネルに移動させる場合は、`parent`に`00000000-0000-0000-0000-000000000000`を指定してください。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **patchChannelRequest** | [**PatchChannelRequest**](PatchChannelRequest.md) |  | [optional]  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict 変更後の名前のチャンネルが既に存在しています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editchannelsubscribers"></a>
# **EditChannelSubscribers**
> void EditChannelSubscribers (Guid channelId, PatchChannelSubscribersRequest patchChannelSubscribersRequest = null)

チャンネルの通知購読者を編集

指定したチャンネルの通知購読者を編集します。 リクエストに含めなかったユーザーの通知購読状態は変更しません。 また、存在しないユーザーを指定した場合は無視されます。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **patchChannelSubscribersRequest** | [**PatchChannelSubscribersRequest**](PatchChannelSubscribersRequest.md) |  | [optional]  |

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
| **403** | Forbidden 指定したチャンネルの通知購読者は変更できません。 |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editchanneltopic"></a>
# **EditChannelTopic**
> void EditChannelTopic (Guid channelId, PutChannelTopicRequest putChannelTopicRequest = null)

チャンネルトピックを編集

指定したチャンネルのトピックを編集します。 アーカイブされているチャンネルのトピックは編集できません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **putChannelTopicRequest** | [**PutChannelTopicRequest**](PutChannelTopicRequest.md) |  | [optional]  |

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
| **204** | No Content チャンネルトピックが編集されました |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannel"></a>
# **GetChannel**
> Channel GetChannel (Guid channelId)

チャンネル情報を取得

指定したチャンネルの情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**Channel**](Channel.md)

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

<a id="getchannelbots"></a>
# **GetChannelBots**
> List&lt;BotUser&gt; GetChannelBots (Guid channelId)

チャンネル参加中のBOTのリストを取得

指定したチャンネルに参加しているBOTのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**List&lt;BotUser&gt;**](BotUser.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelevents"></a>
# **GetChannelEvents**
> List&lt;ChannelEvent&gt; GetChannelEvents (Guid channelId, int limit = null, int offset = null, DateTimeOffset since = null, DateTimeOffset until = null, bool inclusive = null, string order = null)

チャンネルイベントのリストを取得

指定したチャンネルのイベントリストを取得します。


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

[**List&lt;ChannelEvent&gt;**](ChannelEvent.md)

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

<a id="getchannelpath"></a>
# **GetChannelPath**
> ChannelPath GetChannelPath (Guid channelId)

指定したチャンネルパスを取得


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**ChannelPath**](ChannelPath.md)

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

<a id="getchannelpins"></a>
# **GetChannelPins**
> List&lt;Pin&gt; GetChannelPins (Guid channelId)

チャンネルピンのリストを取得

指定したチャンネルにピン留めされているピンメッセージのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**List&lt;Pin&gt;**](Pin.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelstats"></a>
# **GetChannelStats**
> ChannelStats GetChannelStats (Guid channelId, bool excludeDeletedMessages = null)

チャンネル統計情報を取得

指定したチャンネルの統計情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **excludeDeletedMessages** | **bool** | 削除されたメッセージを除外するかどうか(デフォルト false) | [optional]  |

### Return type

[**ChannelStats**](ChannelStats.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelsubscribers"></a>
# **GetChannelSubscribers**
> List&lt;Guid&gt; GetChannelSubscribers (Guid channelId)

チャンネルの通知購読者のリストを取得

指定したチャンネルを通知購読しているユーザーのUUIDのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

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
| **403** | Forbidden プライベートチャンネル・強制通知チャンネルの設定は取得できません。 |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchanneltopic"></a>
# **GetChannelTopic**
> ChannelTopic GetChannelTopic (Guid channelId)

チャンネルトピックを取得

指定したチャンネルのトピックを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**ChannelTopic**](ChannelTopic.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelviewers"></a>
# **GetChannelViewers**
> List&lt;ChannelViewer&gt; GetChannelViewers (Guid channelId)

チャンネル閲覧者リストを取得

指定したチャンネルの閲覧者のリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |

### Return type

[**List&lt;ChannelViewer&gt;**](ChannelViewer.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannels"></a>
# **GetChannels**
> ChannelList GetChannels (bool includeDm = null, string path = null)

チャンネルリストを取得

チャンネルのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeDm** | **bool** | ダイレクトメッセージチャンネルをレスポンスに含めるかどうか | [optional] [default to false] |
| **path** | **string** | パスが一致するチャンネルのみを取得する | [optional]  |

### Return type

[**ChannelList**](ChannelList.md)

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

<a id="setchannelsubscribers"></a>
# **SetChannelSubscribers**
> void SetChannelSubscribers (Guid channelId, PutChannelSubscribersRequest putChannelSubscribersRequest = null)

チャンネルの通知購読者を設定

指定したチャンネルの通知購読者を設定します。 リクエストに含めなかったユーザーの通知購読状態はオフになります。 また、存在しないユーザーを指定した場合は無視されます。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | チャンネルUUID |  |
| **putChannelSubscribersRequest** | [**PutChannelSubscribersRequest**](PutChannelSubscribersRequest.md) |  | [optional]  |

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
| **403** | Forbidden 指定したチャンネルの通知購読者は変更できません。 |  -  |
| **404** | Not Found チャンネルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

