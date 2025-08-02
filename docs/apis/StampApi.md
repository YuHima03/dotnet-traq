# Traq.Api.StampApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMessageStamp**](StampApi.md#addmessagestamp) | **POST** /messages/{messageId}/stamps/{stampId} | スタンプを押す |
| [**ChangeStampImage**](StampApi.md#changestampimage) | **PUT** /stamps/{stampId}/image | スタンプ画像を変更 |
| [**CreateStamp**](StampApi.md#createstamp) | **POST** /stamps | スタンプを作成 |
| [**CreateStampPalette**](StampApi.md#createstamppalette) | **POST** /stamp-palettes | スタンプパレットを作成 |
| [**DeleteStamp**](StampApi.md#deletestamp) | **DELETE** /stamps/{stampId} | スタンプを削除 |
| [**DeleteStampPalette**](StampApi.md#deletestamppalette) | **DELETE** /stamp-palettes/{paletteId} | スタンプパレットを削除 |
| [**EditStamp**](StampApi.md#editstamp) | **PATCH** /stamps/{stampId} | スタンプ情報を変更 |
| [**EditStampPalette**](StampApi.md#editstamppalette) | **PATCH** /stamp-palettes/{paletteId} | スタンプパレットを編集 |
| [**GetMessageStamps**](StampApi.md#getmessagestamps) | **GET** /messages/{messageId}/stamps | メッセージのスタンプリストを取得 |
| [**GetMyStampHistory**](StampApi.md#getmystamphistory) | **GET** /users/me/stamp-history | スタンプ履歴を取得 |
| [**GetStamp**](StampApi.md#getstamp) | **GET** /stamps/{stampId} | スタンプ情報を取得 |
| [**GetStampImage**](StampApi.md#getstampimage) | **GET** /stamps/{stampId}/image | スタンプ画像を取得 |
| [**GetStampPalette**](StampApi.md#getstamppalette) | **GET** /stamp-palettes/{paletteId} | スタンプパレットを取得 |
| [**GetStampPalettes**](StampApi.md#getstamppalettes) | **GET** /stamp-palettes | スタンプパレットのリストを取得 |
| [**GetStampStats**](StampApi.md#getstampstats) | **GET** /stamps/{stampId}/stats | スタンプ統計情報を取得 |
| [**GetStamps**](StampApi.md#getstamps) | **GET** /stamps | スタンプリストを取得 |
| [**RemoveMessageStamp**](StampApi.md#removemessagestamp) | **DELETE** /messages/{messageId}/stamps/{stampId} | スタンプを消す |

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

<a id="changestampimage"></a>
# **ChangeStampImage**
> void ChangeStampImage (Guid stampId, System.IO.Stream file)

スタンプ画像を変更

指定したスタンプの画像を変更します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |
| **file** | **System.IO.Stream****System.IO.Stream** | スタンプ画像(1MBまでのpng, jpeg, gif) |  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createstamp"></a>
# **CreateStamp**
> Stamp CreateStamp (string name, System.IO.Stream file)

スタンプを作成

スタンプを新規作成します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | スタンプ名 |  |
| **file** | **System.IO.Stream****System.IO.Stream** | スタンプ画像(1MBまでのpng, jpeg, gif) |  |

### Return type

[**Stamp**](Stamp.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createstamppalette"></a>
# **CreateStampPalette**
> StampPalette CreateStampPalette (PostStampPaletteRequest postStampPaletteRequest = null)

スタンプパレットを作成

スタンプパレットを作成します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postStampPaletteRequest** | [**PostStampPaletteRequest**](PostStampPaletteRequest.md) |  | [optional]  |

### Return type

[**StampPalette**](StampPalette.md)

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

<a id="deletestamp"></a>
# **DeleteStamp**
> void DeleteStamp (Guid stampId)

スタンプを削除

指定したスタンプを削除します。 対象のスタンプの削除権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **204** | No Content スタンプが削除されました。 |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletestamppalette"></a>
# **DeleteStampPalette**
> void DeleteStampPalette (Guid paletteId)

スタンプパレットを削除

指定したスタンプパレットを削除します。 対象のスタンプパレットの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paletteId** | **Guid** | スタンプパレットUUID |  |

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
| **403** | Forbidden 対象のスタンプパレットを削除する権限がありません。 |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editstamp"></a>
# **EditStamp**
> void EditStamp (Guid stampId, PatchStampRequest patchStampRequest = null)

スタンプ情報を変更

指定したスタンプの情報を変更します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |
| **patchStampRequest** | [**PatchStampRequest**](PatchStampRequest.md) |  | [optional]  |

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
| **204** | No Content スタンプ情報が変更されました。 |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editstamppalette"></a>
# **EditStampPalette**
> void EditStampPalette (Guid paletteId, PatchStampPaletteRequest patchStampPaletteRequest = null)

スタンプパレットを編集

指定したスタンプパレットを編集します。 リクエストのスタンプの配列の順番は保存されて変更されます。 対象のスタンプパレットの管理権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paletteId** | **Guid** | スタンプパレットUUID |  |
| **patchStampPaletteRequest** | [**PatchStampPaletteRequest**](PatchStampPaletteRequest.md) |  | [optional]  |

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
| **403** | Forbidden 対象のスタンプパレットを編集する権限がありません。 |  -  |
| **404** | Not Found |  -  |

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

<a id="getstamp"></a>
# **GetStamp**
> Stamp GetStamp (Guid stampId)

スタンプ情報を取得

指定したスタンプの情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |

### Return type

[**Stamp**](Stamp.md)

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

<a id="getstampimage"></a>
# **GetStampImage**
> System.IO.Stream GetStampImage (Guid stampId)

スタンプ画像を取得

指定したIDのスタンプ画像を返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, image/gif, image/jpeg


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstamppalette"></a>
# **GetStampPalette**
> StampPalette GetStampPalette (Guid paletteId)

スタンプパレットを取得

指定したスタンプパレットの情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paletteId** | **Guid** | スタンプパレットUUID |  |

### Return type

[**StampPalette**](StampPalette.md)

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

<a id="getstamppalettes"></a>
# **GetStampPalettes**
> List&lt;StampPalette&gt; GetStampPalettes ()

スタンプパレットのリストを取得

自身が所有しているスタンプパレットのリストを取得します。


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;StampPalette&gt;**](StampPalette.md)

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

<a id="getstampstats"></a>
# **GetStampStats**
> StampStats GetStampStats (Guid stampId)

スタンプ統計情報を取得

指定したスタンプの統計情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stampId** | **Guid** | スタンプUUID |  |

### Return type

[**StampStats**](StampStats.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found スタンプが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstamps"></a>
# **GetStamps**
> List&lt;StampWithThumbnail&gt; GetStamps (bool includeUnicode = null, string type = null)

スタンプリストを取得

スタンプのリストを取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeUnicode** | **bool** | Unicode絵文字を含ませるかどうか Deprecated: typeクエリを指定しなければ全てのスタンプを取得できるため、そちらを利用してください  | [optional] [default to true] |
| **type** | **string** | 取得するスタンプの種類 | [optional]  |

### Return type

[**List&lt;StampWithThumbnail&gt;**](StampWithThumbnail.md)

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

