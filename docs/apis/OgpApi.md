# Traq.Api.OgpApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteOgpCache**](OgpApi.md#deleteogpcache) | **DELETE** /ogp/cache | OGP情報のキャッシュを削除 |
| [**GetOgp**](OgpApi.md#getogp) | **GET** /ogp | OGP情報を取得 |

<a id="deleteogpcache"></a>
# **DeleteOgpCache**
> void DeleteOgpCache (string url)

OGP情報のキャッシュを削除

指定されたURLのOGP情報のキャッシュを削除します。


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **url** | **string** | OGPのキャッシュを削除したいURL |  |

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
| **204** | No Content |  -  |
| **400** | 指定したURLが不正です。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getogp"></a>
# **GetOgp**
> Ogp GetOgp (string url)

OGP情報を取得

指定されたURLのOGP情報を取得します。 指定されたURLに対するOGP情報が見つからなかった場合、typeがemptyに設定された空のOGP情報を返します。 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **url** | **string** | OGPを取得したいURL |  |

### Return type

[**Ogp**](Ogp.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 指定したURLが不正です。 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

