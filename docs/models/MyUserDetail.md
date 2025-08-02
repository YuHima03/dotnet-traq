# Traq.Model.MyUserDetail
自分のユーザー詳細情報

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | ユーザーUUID | 
**Bio** | **string** | 自己紹介(biography) | 
**Groups** | **List&lt;Guid&gt;** | 所属グループのUUIDの配列 | 
**Tags** | [**List&lt;UserTag&gt;**](UserTag.md) | タグリスト | 
**UpdatedAt** | **DateTimeOffset** | 更新日時 | 
**TwitterId** | **string** | Twitter ID | 
**Name** | **string** | ユーザー名 | 
**DisplayName** | **string** | ユーザー表示名 | 
**IconFileId** | **Guid** | アイコンファイルUUID | 
**Bot** | **bool** | BOTかどうか | 
**State** | **UserAccountState** |  | 
**Permissions** | [**List&lt;UserPermission&gt;**](UserPermission.md) | 所有している権限の配列 | 
**LastOnline** | **DateTimeOffset** | 最終オンライン日時 | 
**HomeChannel** | **Guid** | ホームチャンネル | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

