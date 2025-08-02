# Traq.Api.PinApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePin**](PinApi.md#createpin) | **POST** /messages/{messageId}/pin | ピン留めする |
| [**GetChannelPins**](PinApi.md#getchannelpins) | **GET** /channels/{channelId}/pins | チャンネルピンのリストを取得 |
| [**GetPin**](PinApi.md#getpin) | **GET** /messages/{messageId}/pin | ピン留めを取得 |
| [**RemovePin**](PinApi.md#removepin) | **DELETE** /messages/{messageId}/pin | ピン留めを外す |

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

