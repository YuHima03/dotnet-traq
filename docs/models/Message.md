# Traq.Model.Message
メッセージ

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | メッセージUUID | 
**UserId** | **Guid** | 投稿者UUID | 
**ChannelId** | **Guid** | チャンネルUUID | 
**Content** | **string** | メッセージ本文 | 
**CreatedAt** | **DateTimeOffset** | 投稿日時 | 
**UpdatedAt** | **DateTimeOffset** | 編集日時 | 
**Pinned** | **bool** | ピン留めされているかどうか | 
**Stamps** | [**List&lt;MessageStamp&gt;**](MessageStamp.md) | 押されているスタンプの配列 | 
**ThreadId** | **Guid** | スレッドUUID | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

