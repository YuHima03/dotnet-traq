# Traq.Api.ActivityApi

All URIs are relative to *https://q.trap.jp/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetActivityTimeline**](ActivityApi.md#getactivitytimeline) | **GET** /activity/timeline | アクテビティタイムラインを取得 |
| [**GetOnlineUsers**](ActivityApi.md#getonlineusers) | **GET** /activity/onlines | オンラインユーザーリストを取得 |

<a id="getactivitytimeline"></a>
# **GetActivityTimeline**
> List&lt;ActivityTimelineMessage&gt; GetActivityTimeline (int limit = null, bool all = null, bool perChannel = null)

アクテビティタイムラインを取得

パブリックチャンネルの直近の投稿メッセージを作成日時の降順で取得します。 `all`が`true`でない場合、購読チャンネルのみのタイムラインを取得します


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int** | 取得する件数 | [optional] [default to 50] |
| **all** | **bool** | 全てのチャンネルのタイムラインを取得する | [optional] [default to false] |
| **perChannel** | **bool** | 同じチャンネルのメッセージは最新のもののみ取得するか | [optional] [default to false] |

### Return type

[**List&lt;ActivityTimelineMessage&gt;**](ActivityTimelineMessage.md)

### Authorization

[OAuth2](../README.md#OAuth2), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getonlineusers"></a>
# **GetOnlineUsers**
> List&lt;string&gt; GetOnlineUsers ()

オンラインユーザーリストを取得

現在オンラインな(SSEまたはWSが接続中)ユーザーのUUIDのリストを返します。


### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

