# Traq.Api.PublicApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPublicUserIcon**](PublicApi.md#getpublicusericon) | **GET** /public/icon/{username} | ユーザーのアイコン画像を取得 |
| [**GetServerVersion**](PublicApi.md#getserverversion) | **GET** /version | バージョンを取得 |

<a id="getpublicusericon"></a>
# **GetPublicUserIcon**
> System.IO.Stream GetPublicUserIcon (string username)

ユーザーのアイコン画像を取得

ユーザーのアイコン画像を取得します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | ユーザー名 |  |

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getserverversion"></a>
# **GetServerVersion**
> ModelVersion GetServerVersion ()

バージョンを取得

サーバーバージョン及びサーバーフラグ情報を取得します。


### Parameters
This endpoint does not need any parameter.
### Return type

[**ModelVersion**](ModelVersion.md)

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

