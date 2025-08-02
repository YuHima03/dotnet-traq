# Traq.Api.StarApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMyStar**](StarApi.md#addmystar) | **POST** /users/me/stars | チャンネルをスターに追加 |
| [**GetMyStars**](StarApi.md#getmystars) | **GET** /users/me/stars | スターチャンネルリストを取得 |
| [**RemoveMyStar**](StarApi.md#removemystar) | **DELETE** /users/me/stars/{channelId} | チャンネルをスターから削除します |

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

