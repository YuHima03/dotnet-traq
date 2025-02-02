# Traq.Model.GetClient200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | クライアントUUID | 
**Name** | **string** | クライアント名 | 
**Description** | **string** | 説明 | 
**DeveloperId** | **Guid** | クライアント開発者UUID | 
**Scopes** | [**List&lt;OAuth2Scope&gt;**](OAuth2Scope.md) | 要求スコープの配列 | 
**Confidential** | **bool** | confidential client なら true, public client なら false | 
**CallbackUrl** | **string** | コールバックURL | 
**Secret** | **string** | クライアントシークレット | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

