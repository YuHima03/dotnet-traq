# Traq.Api.ClipApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClipMessage**](ClipApi.md#clipmessage) | **POST** /clip-folders/{folderId}/messages | メッセージをクリップフォルダに追加 |
| [**CreateClipFolder**](ClipApi.md#createclipfolder) | **POST** /clip-folders | クリップフォルダを作成 |
| [**DeleteClipFolder**](ClipApi.md#deleteclipfolder) | **DELETE** /clip-folders/{folderId} | クリップフォルダを削除 |
| [**EditClipFolder**](ClipApi.md#editclipfolder) | **PATCH** /clip-folders/{folderId} | クリップフォルダ情報を編集 |
| [**GetClipFolder**](ClipApi.md#getclipfolder) | **GET** /clip-folders/{folderId} | クリップフォルダ情報を取得 |
| [**GetClipFolders**](ClipApi.md#getclipfolders) | **GET** /clip-folders | クリップフォルダのリストを取得 |
| [**GetClips**](ClipApi.md#getclips) | **GET** /clip-folders/{folderId}/messages | フォルダ内のクリップのリストを取得 |
| [**GetMessageClips**](ClipApi.md#getmessageclips) | **GET** /messages/{messageId}/clips | 自分のクリップを取得 |
| [**UnclipMessage**](ClipApi.md#unclipmessage) | **DELETE** /clip-folders/{folderId}/messages/{messageId} | メッセージをクリップフォルダから除外 |

<a id="clipmessage"></a>
# **ClipMessage**
> ClippedMessage ClipMessage (Guid folderId, PostClipFolderMessageRequest postClipFolderMessageRequest = null)

メッセージをクリップフォルダに追加

指定したメッセージを指定したクリップフォルダに追加します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
| **postClipFolderMessageRequest** | [**PostClipFolderMessageRequest**](PostClipFolderMessageRequest.md) |  | [optional]  |

### Return type

[**ClippedMessage**](ClippedMessage.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |
| **409** | Conflict 既に追加されています。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createclipfolder"></a>
# **CreateClipFolder**
> ClipFolder CreateClipFolder (PostClipFolderRequest postClipFolderRequest = null)

クリップフォルダを作成

クリップフォルダを作成します。 既にあるフォルダと同名のフォルダを作成することは可能です。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postClipFolderRequest** | [**PostClipFolderRequest**](PostClipFolderRequest.md) |  | [optional]  |

### Return type

[**ClipFolder**](ClipFolder.md)

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

<a id="deleteclipfolder"></a>
# **DeleteClipFolder**
> void DeleteClipFolder (Guid folderId)

クリップフォルダを削除

指定したクリップフォルダを削除します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |

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
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editclipfolder"></a>
# **EditClipFolder**
> void EditClipFolder (Guid folderId, PatchClipFolderRequest patchClipFolderRequest = null)

クリップフォルダ情報を編集

指定したクリップフォルダの情報を編集します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
| **patchClipFolderRequest** | [**PatchClipFolderRequest**](PatchClipFolderRequest.md) |  | [optional]  |

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
| **204** | No Content 編集しました。 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclipfolder"></a>
# **GetClipFolder**
> ClipFolder GetClipFolder (Guid folderId)

クリップフォルダ情報を取得

指定したクリップフォルダの情報を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |

### Return type

[**ClipFolder**](ClipFolder.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclipfolders"></a>
# **GetClipFolders**
> List&lt;ClipFolder&gt; GetClipFolders ()

クリップフォルダのリストを取得

自身が所有するクリップフォルダのリストを取得します。


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ClipFolder&gt;**](ClipFolder.md)

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

<a id="getclips"></a>
# **GetClips**
> List&lt;ClippedMessage&gt; GetClips (Guid folderId, int limit = null, int offset = null, string order = null)

フォルダ内のクリップのリストを取得

指定したフォルダ内のクリップのリストを取得します。 `order`を指定しない場合、クリップした日時の新しい順で返されます。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
| **limit** | **int** | 取得する件数 | [optional]  |
| **offset** | **int** | 取得するオフセット | [optional] [default to 0] |
| **order** | **string** | 昇順か降順か | [optional] [default to desc] |

### Return type

[**List&lt;ClippedMessage&gt;**](ClippedMessage.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

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

<a id="unclipmessage"></a>
# **UnclipMessage**
> void UnclipMessage (Guid folderId, Guid messageId)

メッセージをクリップフォルダから除外

指定したフォルダから指定したメッセージのクリップを除外します。 既に外されているメッセージを指定した場合は204を返します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **Guid** | クリップフォルダUUID |  |
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
| **204** | No Content 外しました。 |  -  |
| **404** | Not Found クリップフォルダが見つかりません。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

