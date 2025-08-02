# Traq.Model.UserDetail
ユーザー詳細情報

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | ユーザーUUID | 
**State** | **UserAccountState** |  | 
**Bot** | **bool** | BOTかどうか | 
**IconFileId** | **Guid** | アイコンファイルUUID | 
**DisplayName** | **string** | ユーザー表示名 | 
**Name** | **string** | ユーザー名 | 
**TwitterId** | **string** | Twitter ID | 
**UpdatedAt** | **DateTimeOffset** | 更新日時 | 
**Tags** | [**List&lt;UserTag&gt;**](UserTag.md) | タグリスト | 
**Groups** | **List&lt;Guid&gt;** | 所属グループのUUIDの配列 | 
**Bio** | **string** | 自己紹介(biography) | 
**LastOnline** | **DateTimeOffset** | 最終オンライン日時 | 
**HomeChannel** | **Guid** | ホームチャンネル | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

