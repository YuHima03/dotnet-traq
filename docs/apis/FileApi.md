# Traq.Api.FileApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteFile**](FileApi.md#deletefile) | **DELETE** /files/{fileId} | ファイルを削除 |
| [**GetFile**](FileApi.md#getfile) | **GET** /files/{fileId} | ファイルをダウンロード |
| [**GetFileMeta**](FileApi.md#getfilemeta) | **GET** /files/{fileId}/meta | ファイルメタを取得 |
| [**GetFiles**](FileApi.md#getfiles) | **GET** /files | ファイルメタのリストを取得 |
| [**GetThumbnailImage**](FileApi.md#getthumbnailimage) | **GET** /files/{fileId}/thumbnail | サムネイル画像を取得 |
| [**PostFile**](FileApi.md#postfile) | **POST** /files | ファイルをアップロード |

<a id="deletefile"></a>
# **DeleteFile**
> void DeleteFile (Guid fileId)

ファイルを削除

指定したファイルを削除します。 指定したファイルの削除権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **Guid** | ファイルUUID |  |

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
| **204** | No Content ファイルが削除できました。 |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfile"></a>
# **GetFile**
> System.IO.Stream GetFile (Guid fileId, int dl = null)

ファイルをダウンロード

指定したファイル本体を取得します。 指定したファイルへのアクセス権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **Guid** | ファイルUUID |  |
| **dl** | **int** | 1を指定するとレスポンスにContent-Dispositionヘッダーが付与されます | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK ファイル本体を返します。 application/octet-streamで返すことになっていますが、ファイルの形式によって変わります。 |  * Content-Disposition - https://developer.mozilla.org/ja/docs/Web/HTTP/Headers/Content-Disposition <br>  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfilemeta"></a>
# **GetFileMeta**
> FileInfo GetFileMeta (Guid fileId)

ファイルメタを取得

指定したファイルのメタ情報を取得します。 指定したファイルへのアクセス権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **Guid** | ファイルUUID |  |

### Return type

[**FileInfo**](FileInfo.md)

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
| **404** | Not Found ファイルが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfiles"></a>
# **GetFiles**
> List&lt;FileInfo&gt; GetFiles (Guid channelId = null, int limit = null, int offset = null, DateTimeOffset since = null, DateTimeOffset until = null, bool inclusive = null, string order = null, bool mine = null)

ファイルメタのリストを取得

指定したクエリでファイルメタのリストを取得します。 クエリパラメータ`channelId`, `mine`の少なくともいずれかが必須です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelId** | **Guid** | アップロード先チャンネルUUID | [optional]  |
| **limit** | **int** | 取得する件数 | [optional]  |
| **offset** | **int** | 取得するオフセット | [optional] [default to 0] |
| **since** | **DateTimeOffset** | 取得する時間範囲の開始日時 | [optional] [default to &quot;0000-01-01T00:00Z&quot;] |
| **until** | **DateTimeOffset** | 取得する時間範囲の終了日時 | [optional]  |
| **inclusive** | **bool** | 範囲の端を含めるかどうか | [optional] [default to false] |
| **order** | **string** | 昇順か降順か | [optional] [default to desc] |
| **mine** | **bool** | アップロード者が自分のファイルのみを取得するか | [optional] [default to false] |

### Return type

[**List&lt;FileInfo&gt;**](FileInfo.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getthumbnailimage"></a>
# **GetThumbnailImage**
> System.IO.Stream GetThumbnailImage (Guid fileId, ThumbnailType type = null)

サムネイル画像を取得

指定したファイルのサムネイル画像を取得します。 指定したファイルへのアクセス権限が必要です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **Guid** | ファイルUUID |  |
| **type** | **ThumbnailType** | 取得するサムネイルのタイプ | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, image/jpeg


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found ファイルが見つからない、またはサムネイル画像が存在しません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postfile"></a>
# **PostFile**
> FileInfo PostFile (System.IO.Stream file, Guid channelId)

ファイルをアップロード

指定したチャンネルにファイルをアップロードします。 アーカイブされているチャンネルにはアップロード出来ません。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | ファイル本体 |  |
| **channelId** | **Guid** | アップロード先チャンネルUUID |  |

### Return type

[**FileInfo**](FileInfo.md)

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
| **411** | Length Required |  -  |
| **413** | Request Entity Too Large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

