# Traq.Model.BotDetail
BOT詳細情報

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | BOT UUID | 
**UpdatedAt** | **DateTimeOffset** | 更新日時 | 
**CreatedAt** | **DateTimeOffset** | 作成日時 | 
**Mode** | **BotMode** |  | 
**State** | **BotState** |  | 
**SubscribeEvents** | **List&lt;string&gt;** | BOTが購読しているイベントの配列 | 
**DeveloperId** | **Guid** | BOT開発者UUID | 
**Description** | **string** | 説明 | 
**BotUserId** | **Guid** | BOTユーザーUUID | 
**Tokens** | [**BotTokens**](BotTokens.md) |  | 
**Endpoint** | **string** | BOTサーバーエンドポイント | 
**Privileged** | **bool** | 特権BOTかどうか | 
**Channels** | **List&lt;Guid&gt;** | BOTが参加しているチャンネルのUUID配列 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

