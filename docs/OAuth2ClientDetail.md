# Traq.Model.OAuth2ClientDetail
OAuth2クライアント詳細情報

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | クライアントUUID | 
**DeveloperId** | **Guid** | クライアント開発者UUID | 
**Description** | **string** | 説明 | 
**Name** | **string** | クライアント名 | 
**Scopes** | [**List&lt;OAuth2Scope&gt;**](OAuth2Scope.md) | 要求スコープの配列 | 
**CallbackUrl** | **string** | コールバックURL | 
**Secret** | **string** | クライアントシークレット | 
**Confidential** | **bool** | confidential client なら true, public client なら false | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

