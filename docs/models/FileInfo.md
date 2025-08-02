# Traq.Model.FileInfo
ファイル情報

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | ファイルUUID | 
**Name** | **string** | ファイル名 | 
**Mime** | **string** | MIMEタイプ | 
**Size** | **long** | ファイルサイズ | 
**Md5** | **string** | MD5ハッシュ | 
**IsAnimatedImage** | **bool** | アニメーション画像かどうか | 
**CreatedAt** | **DateTimeOffset** | アップロード日時 | 
**Thumbnails** | [**List&lt;ThumbnailInfo&gt;**](ThumbnailInfo.md) |  | 
**Thumbnail** | [**FileInfoThumbnail**](FileInfoThumbnail.md) |  | 
**ChannelId** | **Guid** | 属しているチャンネルUUID | 
**UploaderId** | **Guid** | アップロード者UUID | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

