# Traq.Api.WebrtcApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetWebRTCState**](WebrtcApi.md#getwebrtcstate) | **GET** /webrtc/state | WebRTC状態を取得 |
| [**PostWebRTCAuthenticate**](WebrtcApi.md#postwebrtcauthenticate) | **POST** /webrtc/authenticate | Skyway用認証API |

<a id="getwebrtcstate"></a>
# **GetWebRTCState**
> List&lt;WebRTCUserState&gt; GetWebRTCState ()

WebRTC状態を取得

現在のWebRTC状態を取得します。


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WebRTCUserState&gt;**](WebRTCUserState.md)

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

<a id="postwebrtcauthenticate"></a>
# **PostWebRTCAuthenticate**
> WebRTCAuthenticateResult PostWebRTCAuthenticate (PostWebRTCAuthenticateRequest postWebRTCAuthenticateRequest = null)

Skyway用認証API

Skyway WebRTC用の認証API


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postWebRTCAuthenticateRequest** | [**PostWebRTCAuthenticateRequest**](PostWebRTCAuthenticateRequest.md) |  | [optional]  |

### Return type

[**WebRTCAuthenticateResult**](WebRTCAuthenticateResult.md)

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
| **503** | Service Unavailable WebRTCは現在機能を停止しています |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

