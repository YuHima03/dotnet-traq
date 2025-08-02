# Traq.Api.BotApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateBot**](BotApi.md#activatebot) | **POST** /bots/{botId}/actions/activate | BOTをアクティベート |
| [**ChangeBotIcon**](BotApi.md#changeboticon) | **PUT** /bots/{botId}/icon | BOTのアイコン画像を変更 |
| [**ConnectBotWS**](BotApi.md#connectbotws) | **GET** /bots/ws | WebSocket Mode BOT用通知ストリームに接続します |
| [**CreateBot**](BotApi.md#createbot) | **POST** /bots | BOTを作成 |
| [**DeleteBot**](BotApi.md#deletebot) | **DELETE** /bots/{botId} | BOTを削除 |
| [**EditBot**](BotApi.md#editbot) | **PATCH** /bots/{botId} | BOT情報を変更 |
| [**GetBot**](BotApi.md#getbot) | **GET** /bots/{botId} | BOT情報を取得 |
| [**GetBotIcon**](BotApi.md#getboticon) | **GET** /bots/{botId}/icon | BOTのアイコン画像を取得 |
| [**GetBotLogs**](BotApi.md#getbotlogs) | **GET** /bots/{botId}/logs | BOTのイベントログを取得 |
| [**GetBots**](BotApi.md#getbots) | **GET** /bots | BOTリストを取得 |
| [**GetChannelBots**](BotApi.md#getchannelbots) | **GET** /channels/{channelId}/bots | チャンネル参加中のBOTのリストを取得 |
| [**InactivateBot**](BotApi.md#inactivatebot) | **POST** /bots/{botId}/actions/inactivate | BOTをインアクティベート |
| [**LetBotJoinChannel**](BotApi.md#letbotjoinchannel) | **POST** /bots/{botId}/actions/join | BOTをチャンネルに参加させる |
| [**LetBotLeaveChannel**](BotApi.md#letbotleavechannel) | **POST** /bots/{botId}/actions/leave | BOTをチャンネルから退出させる |
| [**ReissueBot**](BotApi.md#reissuebot) | **POST** /bots/{botId}/actions/reissue | BOTのトークンを再発行 |

<a id="activatebot"></a>
# **ActivateBot**
> void ActivateBot (Guid botId)

BOTをアクティベート

指定したBOTを有効化します。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **202** | Accepted |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="changeboticon"></a>
# **ChangeBotIcon**
> void ChangeBotIcon (Guid botId, System.IO.Stream file)

BOTのアイコン画像を変更

指定したBOTのアイコン画像を変更を変更します。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
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
| **404** | Not Found BOTが見つかりません。 |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="connectbotws"></a>
# **ConnectBotWS**
> void ConnectBotWS ()

WebSocket Mode BOT用通知ストリームに接続します

# BOT WebSocketプロトコル  ## 送信  `コマンド:引数1:引数2:...` のような形式のTextMessageをサーバーに送信することで、このWebSocketセッションに対する設定が実行できます。  ### `rtcstate`コマンド 自分のWebRTC状態を変更します。 他のコネクションが既に状態を保持している場合、変更することができません。  `rtcstate:{チャンネルID}:({状態}:{セッションID})*`  チャンネルIDにnullもしくは空文字を指定するか、状態にnullもしくは空文字を指定した場合、WebRTC状態はリセットされます。  `rtcstate:null`, `rtcstate:`, `rtcstate:channelId:null`, `rtcstate:channelId:`  コネクションが切断された場合、自分のWebRTC状態はリセットされます。  ## 受信  TextMessageとして各種イベントが`type`、`reqId`、`body`を持つJSONとして非同期に送られます。 `body`の内容はHTTP Modeの場合のRequest Bodyと同様です。 例外として`ERROR`イベントは`reqId`を持ちません。  例: PINGイベント `{\"type\":\"PING\",\"reqId\":\"requestId\",\"body\":{\"eventTime\":\"2019-05-07T04:50:48.582586882Z\"}}`  ### `ERROR`  コマンドの引数が不正などの理由でコマンドが受理されなかった場合に送られます。 非同期に送られるため、必ずしもコマンドとの対応関係を確定できないことに注意してください。 本番環境ではERRORが送られないようにすることが望ましいです。  `{\"type\":\"ERROR\",\"body\":\"message\"}`


### Parameters
This endpoint does not need any parameter.
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
| **101** | Switching Protocols |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createbot"></a>
# **CreateBot**
> BotDetail CreateBot (PostBotRequest postBotRequest = null)

BOTを作成

BOTを作成します。 作成後に購読イベントの設定を行う必要があります。 さらにHTTP Modeの場合はアクティベーションを行う必要があります。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postBotRequest** | [**PostBotRequest**](PostBotRequest.md) |  | [optional]  |

### Return type

[**BotDetail**](BotDetail.md)

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
| **409** | Conflict 既に使われている名前です。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletebot"></a>
# **DeleteBot**
> void DeleteBot (Guid botId)

BOTを削除

指定したBOTを削除します。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **204** | No Content 削除しました。 |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editbot"></a>
# **EditBot**
> void EditBot (Guid botId, PatchBotRequest patchBotRequest = null)

BOT情報を変更

指定したBOTの情報を変更します。 対象のBOTの管理権限が必要です。 BOT開発者UUIDを変更した場合は、変更先ユーザーにBOT管理権限が移譲され、自分自身は権限を失います。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **patchBotRequest** | [**PatchBotRequest**](PatchBotRequest.md) |  | [optional]  |

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
| **204** | No Content 変更しました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbot"></a>
# **GetBot**
> GetBot200Response GetBot (Guid botId, bool detail = null)

BOT情報を取得

指定したBOTのBOT情報を取得します。 BOT詳細情報を取得する場合は、対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **detail** | **bool** | 詳細情報を含めるかどうか | [optional] [default to false] |

### Return type

[**GetBot200Response**](GetBot200Response.md)

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

<a id="getboticon"></a>
# **GetBotIcon**
> System.IO.Stream GetBotIcon (Guid botId)

BOTのアイコン画像を取得

指定したBOTのアイコン画像を取得を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbotlogs"></a>
# **GetBotLogs**
> List&lt;BotEventLog&gt; GetBotLogs (Guid botId, int limit = null, int offset = null)

BOTのイベントログを取得

指定したBOTのイベントログを取得します。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **limit** | **int** | 取得する件数 | [optional]  |
| **offset** | **int** | 取得するオフセット | [optional] [default to 0] |

### Return type

[**List&lt;BotEventLog&gt;**](BotEventLog.md)

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
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbots"></a>
# **GetBots**
> List&lt;Bot&gt; GetBots (bool all = null)

BOTリストを取得

BOT情報のリストを取得します。 allを指定しない場合、自分が開発者のBOTのみを返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **all** | **bool** | 全てのBOTを取得するかどうか | [optional] [default to false] |

### Return type

[**List&lt;Bot&gt;**](Bot.md)

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

<a id="inactivatebot"></a>
# **InactivateBot**
> void InactivateBot (Guid botId)

BOTをインアクティベート

指定したBOTを無効化します。対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

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
| **204** | No Content BOTがインアクティベートされました。 |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="letbotjoinchannel"></a>
# **LetBotJoinChannel**
> void LetBotJoinChannel (Guid botId, PostBotActionJoinRequest postBotActionJoinRequest = null)

BOTをチャンネルに参加させる

指定したBOTを指定したチャンネルに参加させます。 チャンネルに参加したBOTは、そのチャンネルの各種イベントを受け取るようになります。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **postBotActionJoinRequest** | [**PostBotActionJoinRequest**](PostBotActionJoinRequest.md) |  | [optional]  |

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
| **204** | No Content BOTを参加させました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="letbotleavechannel"></a>
# **LetBotLeaveChannel**
> void LetBotLeaveChannel (Guid botId, PostBotActionLeaveRequest postBotActionLeaveRequest = null)

BOTをチャンネルから退出させる

指定したBOTを指定したチャンネルから退出させます。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |
| **postBotActionLeaveRequest** | [**PostBotActionLeaveRequest**](PostBotActionLeaveRequest.md) |  | [optional]  |

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
| **204** | No Content BOTを退出させました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="reissuebot"></a>
# **ReissueBot**
> BotTokens ReissueBot (Guid botId)

BOTのトークンを再発行

指定したBOTの現在の各種トークンを無効化し、再発行を行います。 対象のBOTの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **botId** | **Guid** | BOTUUID |  |

### Return type

[**BotTokens**](BotTokens.md)

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
| **404** | Not Found BOTが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

