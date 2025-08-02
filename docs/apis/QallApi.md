# Traq.Api.QallApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeParticipantRole**](QallApi.md#changeparticipantrole) | **PATCH** /qall/rooms/{roomId}/participants | ルームでの発言権限を変更 |
| [**GetLiveKitToken**](QallApi.md#getlivekittoken) | **GET** /qall/token | LiveKitトークンを取得 |
| [**GetQallEndpoints**](QallApi.md#getqallendpoints) | **GET** /qall/endpoints | LiveKitエンドポイントを取得 |
| [**GetRoomMetadata**](QallApi.md#getroommetadata) | **GET** /qall/rooms/{roomId}/metadata | ルームのメタデータを取得 |
| [**GetRooms**](QallApi.md#getrooms) | **GET** /qall/rooms | ルームと参加者の一覧を取得 |
| [**GetSoundboardList**](QallApi.md#getsoundboardlist) | **GET** /qall/soundboard | サウンドボード用の音声一覧を取得 |
| [**LiveKitWebhook**](QallApi.md#livekitwebhook) | **POST** /qall/webhook | LiveKit Webhook受信 |
| [**PostSoundboard**](QallApi.md#postsoundboard) | **POST** /qall/soundboard | サウンドボード用の短い音声ファイルをアップロード |
| [**PostSoundboardPlay**](QallApi.md#postsoundboardplay) | **POST** /qall/soundboard/play | アップロード済み音声を LiveKit ルームで再生 |
| [**UpdateRoomMetadata**](QallApi.md#updateroommetadata) | **PATCH** /qall/rooms/{roomId}/metadata | ルームのメタデータを更新 |

<a id="changeparticipantrole"></a>
# **ChangeParticipantRole**
> QallParticipantResponse ChangeParticipantRole (Guid roomId, List<QallParticipantRequest> qallParticipantRequest)

ルームでの発言権限を変更

ルーム内の参加者の発言権限を変更します。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **Guid** | ルームUUID |  |
| **qallParticipantRequest** | [**List&lt;QallParticipantRequest&gt;**](QallParticipantRequest.md) | 発言権限を変更する参加者の情報 |  |

### Return type

[**QallParticipantResponse**](QallParticipantResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 - 発言権限を変更（部分的成功含む） |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getlivekittoken"></a>
# **GetLiveKitToken**
> QallTokenResponse GetLiveKitToken (Guid roomId = null, bool isWebinar = null)

LiveKitトークンを取得

指定したルームに参加するためのLiveKitトークンを取得します。   


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **Guid** | ルームUUID | [optional]  |
| **isWebinar** | **bool** | ウェビナールームかどうか(デフォルト false) | [optional]  |

### Return type

[**QallTokenResponse**](QallTokenResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 - LiveKitトークンを返します |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getqallendpoints"></a>
# **GetQallEndpoints**
> QallEndpointResponse GetQallEndpoints ()

LiveKitエンドポイントを取得

接続可能なLiveKitエンドポイントを取得します。 


### Parameters
This endpoint does not need any parameter.
### Return type

[**QallEndpointResponse**](QallEndpointResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 - LiveKitエンドポイントの取得 |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getroommetadata"></a>
# **GetRoomMetadata**
> QallMetadataResponse GetRoomMetadata (Guid roomId)

ルームのメタデータを取得

ルームのメタデータを取得します。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **Guid** | ルームUUID |  |

### Return type

[**QallMetadataResponse**](QallMetadataResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 - ルームのメタデータを取得 |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrooms"></a>
# **GetRooms**
> List&lt;QallRoomWithParticipants&gt; GetRooms ()

ルームと参加者の一覧を取得

現在存在する(またはアクティブな)ルームと、そのルームに所属している参加者情報を取得します。 


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;QallRoomWithParticipants&gt;**](QallRoomWithParticipants.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 - ルームと参加者一覧の取得 |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsoundboardlist"></a>
# **GetSoundboardList**
> List&lt;SoundboardItem&gt; GetSoundboardList ()

サウンドボード用の音声一覧を取得

DBに保存されたサウンドボード情報を取得します。   各アイテムには soundId, soundName, stampId が含まれます。 


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SoundboardItem&gt;**](SoundboardItem.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | サウンド一覧の取得に成功 |  -  |
| **500** | サーバエラー |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="livekitwebhook"></a>
# **LiveKitWebhook**
> void LiveKitWebhook (Object body)

LiveKit Webhook受信

LiveKit側で設定したWebhookから呼び出されるエンドポイントです。   参加者の入室・退出などのイベントを受け取り、サーバ内で処理を行います。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/webhook+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhookを正常に受信 |  -  |
| **400** | Invalid payload |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postsoundboard"></a>
# **PostSoundboard**
> SoundboardUploadResponse PostSoundboard (System.IO.Stream audio, string soundName, string stampId = null)

サウンドボード用の短い音声ファイルをアップロード

15秒程度の短い音声ファイルを multipart/form-data で送信し、S3(互換ストレージ)にアップロードします。   クライアントは「soundName」というフィールドを送信し、それをDBに保存して関連付けを行います。   また、サーバ側で soundId を自動生成し、S3のファイル名に使用します。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **audio** | **System.IO.Stream****System.IO.Stream** | アップロードする音声ファイル(20秒以内) |  |
| **soundName** | **string** | ユーザが自由につけるサウンド名 |  |
| **stampId** | **string** | アイコンスタンプID | [optional]  |

### Return type

[**SoundboardUploadResponse**](SoundboardUploadResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | アップロード成功 |  -  |
| **400** | ファイルが提供されていない等 |  -  |
| **500** | アップロードエラーなどのサーバエラー |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postsoundboardplay"></a>
# **PostSoundboardPlay**
> SoundboardPlayResponse PostSoundboardPlay (SoundboardPlayRequest soundboardPlayRequest)

アップロード済み音声を LiveKit ルームで再生

S3上にある音声ファイルの署名付きURLを生成し、   Ingressを介して指定ルームに音声を流します。     該当ルームに参加しているユーザであれば再生可能とします。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **soundboardPlayRequest** | [**SoundboardPlayRequest**](SoundboardPlayRequest.md) |  |  |

### Return type

[**SoundboardPlayResponse**](SoundboardPlayResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ingressの作成に成功 |  -  |
| **400** | パラメータ不足 or ユーザが部屋にいない等 |  -  |
| **401** | 認証エラー |  -  |
| **500** | Ingress作成失敗などのサーバエラー |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateroommetadata"></a>
# **UpdateRoomMetadata**
> void UpdateRoomMetadata (Guid roomId, QallMetadataRequest qallMetadataRequest)

ルームのメタデータを更新

ルームのメタデータを更新します。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **Guid** | ルームUUID |  |
| **qallMetadataRequest** | [**QallMetadataRequest**](QallMetadataRequest.md) | ルームのメタデータ |  |

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
| **200** | 成功 - ルームのメタデータを更新 |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

