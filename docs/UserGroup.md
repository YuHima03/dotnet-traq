# Traq.Model.UserGroup
ユーザーグループ

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | グループUUID | 
**Name** | **string** | グループ名 | 
**Description** | **string** | グループ説明 | 
**Type** | **string** | グループタイプ | 
**Icon** | **Guid** | グループアイコンUUID | 
**Members** | [**List&lt;UserGroupMember&gt;**](UserGroupMember.md) | グループメンバーの配列 | 
**CreatedAt** | **DateTimeOffset** | 作成日時 | 
**UpdatedAt** | **DateTimeOffset** | 更新日時 | 
**Admins** | **List&lt;Guid&gt;** | グループ管理者のUUIDの配列 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

