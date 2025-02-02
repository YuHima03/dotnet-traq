# Traq.Model.UnreadChannel
未読チャンネル情報

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelId** | **Guid** | チャンネルUUID | 
**Count** | **int** | 未読メッセージ数 | 
**Noticeable** | **bool** | 自分宛てメッセージが含まれているかどうか | 
**Since** | **DateTimeOffset** | チャンネルの最古の未読メッセージの日時 | 
**UpdatedAt** | **DateTimeOffset** | チャンネルの最新の未読メッセージの日時 | 
**OldestMessageId** | **Guid** | そのチャンネルの未読の中で最も古いメッセージのid | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

