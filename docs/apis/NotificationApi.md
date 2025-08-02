# Traq.Api.NotificationApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EditChannelSubscribers**](NotificationApi.md#editchannelsubscribers) | **PATCH** /channels/{channelId}/subscribers | チャンネルの通知購読者を編集 |
| [**GetChannelSubscribers**](NotificationApi.md#getchannelsubscribers) | **GET** /channels/{channelId}/subscribers | チャンネルの通知購読者のリストを取得 |
| [**GetMyChannelSubscriptions**](NotificationApi.md#getmychannelsubscriptions) | **GET** /users/me/subscriptions | 自分のチャンネル購読状態を取得 |
| [**GetMyUnreadChannels**](NotificationApi.md#getmyunreadchannels) | **GET** /users/me/unread | 未読チャンネルを取得 |
| [**GetMyViewStates**](NotificationApi.md#getmyviewstates) | **GET** /users/me/view-states | 自身のチャンネル閲覧状態一覧を取得 |
| [**ReadChannel**](NotificationApi.md#readchannel) | **DELETE** /users/me/unread/{channelId} | チャンネルを既読にする |
| [**RegisterFCMDevice**](NotificationApi.md#registerfcmdevice) | **POST** /users/me/fcm-device | FCMデバイスを登録 |
| [**SetChannelSubscribeLevel**](NotificationApi.md#setchannelsubscribelevel) | **PUT** /users/me/subscriptions/{channelId} | チャンネル購読レベルを設定 |
| [**SetChannelSubscribers**](NotificationApi.md#setchannelsubscribers) | **PUT** /channels/{channelId}/subscribers | チャンネルの通知購読者を設定 |
| [**Ws**](NotificationApi.md#ws) | **GET** /ws | WebSocket通知ストリームに接続します |

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

<a id="ws"></a>
# **Ws**
> void Ws ()

WebSocket通知ストリームに接続します

# WebSocketプロトコル ## 送信 `コマンド:引数1:引数2:...`のような形式のTextMessageをサーバーに送信することで、このWebSocketセッションに対する設定が実行できる。 ### `viewstate`コマンド このWebSocketセッションが見ているチャンネル(イベントを受け取るチャンネル)を設定する。 現時点では1つのセッションに対して1つのチャンネルしか設定できない。  `viewstate:{チャンネルID}:{閲覧状態}` + チャンネルID: 対象のチャンネルID + 閲覧状態: `none`, `monitoring`, `editing`  最初の`viewstate`コマンドを送る前、または`viewstate:null`, `viewstate:`を送信した後は、このセッションはどこのチャンネルも見ていないことになる。  ### `rtcstate`コマンド 自分のWebRTC状態を変更する。 他のコネクションが既に状態を保持している場合、変更することができません。  `rtcstate:{チャンネルID}:({状態}:{セッションID})*`  コネクションが切断された場合、自分のWebRTC状態はリセットされます。  ### `timeline_streaming`コマンド 全てのパブリックチャンネルの`MESSAGE_CREATED`イベントを受け取るかどうかを設定する。 初期状態は`off`です。  `timeline_streaming:(on|off|true|false)`  ## 受信 TextMessageとして各種イベントが`type`と`body`を持つJSONとして非同期に送られます。  例: ```json {\"type\":\"USER_ONLINE\",\"body\":{\"id\":\"7dd8e07f-7f5d-4331-9176-b56a4299768b\"}} ```  ## イベント一覧  ### `USER_JOINED` ユーザーが新規登録された。  対象: 全員  + `id`: 登録されたユーザーのId  ### `USER_UPDATED` ユーザーの情報が更新された。  対象: 全員  + `id`: 情報が更新されたユーザーのId  ### `USER_TAGS_UPDATED` ユーザーのタグが更新された。  対象: 全員  + `id`: タグが更新されたユーザーのId + `tag_id`: 更新されたタグのId  ### `USER_ICON_UPDATED` ユーザーのアイコンが更新された。  対象: 全員  + `id`: アイコンが更新されたユーザーのId  ### `USER_WEBRTC_STATE_CHANGED` ユーザーのWebRTCの状態が変化した  対象: 全員  + `user_id`: 変更があったユーザーのId + `channel_id`: ユーザーの変更後の接続チャンネルのId + `sessions`: ユーザーの変更後の状態(配列)   + `state`: 状態   + `sessionId`: セッションID  ### `USER_VIEWSTATE_CHANGED` ユーザーのチャンネルの閲覧状態が変化した  対象: 変化したWSセッションを含めた、該当ユーザーのWSセッション全て  + `view_states`: 変化したWSセッションを含めた、該当ユーザーの変更後の状態(配列)   + `key`: WSセッションの識別子   + `channel_id`: 閲覧しているチャンネルId   + `state`: 閲覧状態  ### `USER_ONLINE` ユーザーがオンラインになった。  対象: 全員  + `id`: オンラインになったユーザーのId  ### `USER_OFFLINE` ユーザーがオフラインになった。  対象: 全員  + `id`: オフラインになったユーザーのId  ### `USER_GROUP_CREATED` ユーザーグループが作成された  対象: 全員  + `id`: 作成されたユーザーグループのId  ### `USER_GROUP_UPDATED` ユーザーグループが更新された  対象: 全員  + `id`: 作成されたユーザーグループのId  ### `USER_GROUP_DELETED` ユーザーグループが削除された  対象: 全員  + `id`: 削除されたユーザーグループのId  ### `CHANNEL_CREATED` チャンネルが新規作成された。  対象: 該当チャンネルを閲覧可能な全員  + `id`: 作成されたチャンネルのId + `dm_user_id`: (DMの場合のみ) DM相手のユーザーId  ### `CHANNEL_UPDATED` チャンネルの情報が変更された。  対象: 該当チャンネルを閲覧可能な全員  + `id`: 変更があったチャンネルのId + `dm_user_id`: (DMの場合のみ) DM相手のユーザーId  ### `CHANNEL_DELETED` チャンネルが削除された。  対象: 該当チャンネルを閲覧可能な全員  + `id`: 削除されたチャンネルのId + `dm_user_id`: (DMの場合のみ) DM相手のユーザーId  ### `CHANNEL_STARED` 自分がチャンネルをスターした。  対象: 自分  + `id`: スターしたチャンネルのId  ### `CHANNEL_UNSTARED` 自分がチャンネルのスターを解除した。  対象: 自分  + `id`: スターしたチャンネルのId  ### `CHANNEL_VIEWERS_CHANGED` チャンネルの閲覧者が変化した。  対象: 該当チャンネルを閲覧しているユーザー  + `id`: 変化したチャンネルのId + `viewers`: 変化後の閲覧者(配列)   + `userId`: ユーザーId   + `state`: 閲覧状態   + `updatedAt`: 閲覧状態の更新日時  ### `CHANNEL_SUBSCRIBERS_CHANGED` チャンネルの購読者が変化した。  対象: 該当チャンネルを閲覧しているユーザー  + `id`: 変化したチャンネルのId  ### `MESSAGE_CREATED` メッセージが投稿された。  対象: 投稿チャンネルを閲覧しているユーザー・投稿チャンネルに通知をつけているユーザー・メンションを受けたユーザー  + `id`: 投稿されたメッセージのId + `is_citing`: 投稿されたメッセージがWebSocketを接続しているユーザーの投稿を引用しているかどうか  ### `MESSAGE_UPDATED` メッセージが更新された。  対象: 投稿チャンネルを閲覧しているユーザー  + `id`: 更新されたメッセージのId  ### `MESSAGE_DELETED` メッセージが削除された。  対象: 投稿チャンネルを閲覧しているユーザー  + `id`: 削除されたメッセージのId  ### `MESSAGE_STAMPED` メッセージにスタンプが押された。  対象: 投稿チャンネルを閲覧しているユーザー  + `message_id`: メッセージId + `user_id`: スタンプを押したユーザーのId + `stamp_id`: スタンプのId + `count`: そのユーザーが押した数 + `created_at`: そのユーザーがそのスタンプをそのメッセージに最初に押した日時  ### `MESSAGE_UNSTAMPED` メッセージからスタンプが外された。  対象: 投稿チャンネルを閲覧しているユーザー  + `message_id`: メッセージId + `user_id`: スタンプを押したユーザーのId + `stamp_id`: スタンプのId  ### `MESSAGE_PINNED` メッセージがピン留めされた。  対象: 投稿チャンネルを閲覧しているユーザー  + `message_id`: ピンされたメッセージのID + `channel_id`: ピンされたメッセージのチャンネルID  ### `MESSAGE_UNPINNED` ピン留めされたメッセージのピンが外された。  対象: 投稿チャンネルを閲覧しているユーザー  + `message_id`: ピンが外されたメッセージのID + `channel_id`: ピンが外されたメッセージのチャンネルID  ### `MESSAGE_READ` 自分があるチャンネルのメッセージを読んだ。  対象: 自分  + `id`: 読んだチャンネルId  ### `STAMP_CREATED` スタンプが新しく追加された。  対象: 全員  + `id`: 作成されたスタンプのId  ### `STAMP_UPDATED` スタンプが修正された。  対象: 全員  + `id`: 修正されたスタンプのId  ### `STAMP_DELETED` スタンプが削除された。  対象: 全員  + `id`: 削除されたスタンプのId  ### `STAMP_PALETTE_CREATED` スタンプパレットが新しく追加された。  対象: 自分  + `id`: 作成されたスタンプパレットのId  ### `STAMP_PALETTE_UPDATED` スタンプパレットが修正された。  対象: 自分  + `id`: 修正されたスタンプパレットのId  ### `STAMP_PALETTE_DELETED` スタンプパレットが削除された。  対象: 自分  + `id`: 削除されたスタンプパレットのId  ### `CLIP_FOLDER_CREATED` クリップフォルダーが作成された。  対象：自分  + `id`: 作成されたクリップフォルダーのId  ### `CLIP_FOLDER_UPDATED` クリップフォルダーが修正された。  対象: 自分  + `id`: 更新されたクリップフォルダーのId  ### `CLIP_FOLDER_DELETED` クリップフォルダーが削除された。  対象: 自分  + `id`: 削除されたクリップフォルダーのId  ### `CLIP_FOLDER_MESSAGE_DELETED` クリップフォルダーからメッセージが除外された。  対象: 自分  + `folder_id`: メッセージが除外されたクリップフォルダーのId + `message_id`: クリップフォルダーから除外されたメッセージのId  ### `CLIP_FOLDER_MESSAGE_ADDED` クリップフォルダーにメッセージが追加された。  対象: 自分  + `folder_id`: メッセージが追加されたクリップフォルダーのId + `message_id`: クリップフォルダーに追加されたメッセージのId  ### `QALL_ROOM_STATE_CHANGED` ルーム状態が変更された。  対象: 全員  + `room_id`: 変更されたルームのId + `state`: 変更後のルーム状態   + `roomId`: ルームのID   + `participants`: ルーム内の参加者(配列)     + `identity`: ユーザーID_RandomUUID     + `name`: 表示名     + `joinedAt`: 参加した時刻     + `attributes`: ユーザーに関連付けられたカスタム属性     + `canPublish`: 発言権限   + `isWebinar`: ウェビナールームかどうか   + `metadata`: ルームに関連付けられたカスタム属性  ### `QALL_SOUNDBOARD_ITEM_CREATED` サウンドボードアイテムが作成された。  対象: 全員  + `sound_id`: 作成されたサウンドのId + `name`: サウンド名 + `creator_id`: 作成者のId  ### `QALL_SOUNDBOARD_ITEM_DELETED` サウンドボードアイテムが削除された。  対象: 全員  + `sound_id`: 削除されたサウンドのId


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

