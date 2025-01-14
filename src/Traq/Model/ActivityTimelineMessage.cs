/*
 * traQ v3
 *
 * traQ v3 API
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Traq.Client.FileParameter;
using OpenAPIDateConverter = Traq.Client.OpenAPIDateConverter;

namespace Traq.Model
{
    /// <summary>
    /// Timelineアクテビティ用メッセージ
    /// </summary>
    [DataContract(Name = "ActivityTimelineMessage")]
    public partial class ActivityTimelineMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTimelineMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityTimelineMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTimelineMessage" /> class.
        /// </summary>
        /// <param name="id">メッセージUUID (required).</param>
        /// <param name="userId">投稿者UUID (required).</param>
        /// <param name="channelId">チャンネルUUID (required).</param>
        /// <param name="content">メッセージ本文 (required).</param>
        /// <param name="createdAt">投稿日時 (required).</param>
        /// <param name="updatedAt">編集日時 (required).</param>
        public ActivityTimelineMessage(Guid id = default(Guid), Guid userId = default(Guid), Guid channelId = default(Guid), string content = default(string), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset))
        {
            this.Id = id;
            this.UserId = userId;
            this.ChannelId = channelId;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for ActivityTimelineMessage and cannot be null");
            }
            this.Content = content;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// メッセージUUID
        /// </summary>
        /// <value>メッセージUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// 投稿者UUID
        /// </summary>
        /// <value>投稿者UUID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// チャンネルUUID
        /// </summary>
        /// <value>チャンネルUUID</value>
        [DataMember(Name = "channelId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ChannelId { get; set; }

        /// <summary>
        /// メッセージ本文
        /// </summary>
        /// <value>メッセージ本文</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// 投稿日時
        /// </summary>
        /// <value>投稿日時</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 編集日時
        /// </summary>
        /// <value>編集日時</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivityTimelineMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
