# Traq.Model.ChannelEventDetail
イベント内容

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **Guid** | 作成者UUID | 
**Before** | **Guid** | 変更前親チャンネルUUID | 
**After** | **Guid** | 変更後親チャンネルUUID | 
**On** | **List&lt;Guid&gt;** | オンにされたユーザーのUUID配列 | 
**Off** | **List&lt;Guid&gt;** | オフにされたユーザーのUUID配列 | 
**MessageId** | **Guid** | メッセージUUID | 
**Visibility** | **bool** | 変更後可視状態 | 
**Force** | **bool** | 変更後強制通知状態 | 
**ChannelId** | **Guid** | チャンネルUUID | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

