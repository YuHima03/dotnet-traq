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
    /// 未読チャンネル情報
    /// </summary>
    [DataContract(Name = "UnreadChannel")]
    public partial class UnreadChannel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreadChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnreadChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreadChannel" /> class.
        /// </summary>
        /// <param name="channelId">チャンネルUUID (required).</param>
        /// <param name="count">未読メッセージ数 (required).</param>
        /// <param name="noticeable">自分宛てメッセージが含まれているかどうか (required).</param>
        /// <param name="since">チャンネルの最古の未読メッセージの日時 (required).</param>
        /// <param name="updatedAt">チャンネルの最新の未読メッセージの日時 (required).</param>
        /// <param name="oldestMessageId">そのチャンネルの未読の中で最も古いメッセージのid (required).</param>
        public UnreadChannel(Guid channelId = default(Guid), int count = default(int), bool noticeable = default(bool), DateTimeOffset since = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), Guid oldestMessageId = default(Guid))
        {
            this.ChannelId = channelId;
            this.Count = count;
            this.Noticeable = noticeable;
            this.Since = since;
            this.UpdatedAt = updatedAt;
            this.OldestMessageId = oldestMessageId;
        }

        /// <summary>
        /// チャンネルUUID
        /// </summary>
        /// <value>チャンネルUUID</value>
        [DataMember(Name = "channelId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ChannelId { get; set; }

        /// <summary>
        /// 未読メッセージ数
        /// </summary>
        /// <value>未読メッセージ数</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public int Count { get; set; }

        /// <summary>
        /// 自分宛てメッセージが含まれているかどうか
        /// </summary>
        /// <value>自分宛てメッセージが含まれているかどうか</value>
        [DataMember(Name = "noticeable", IsRequired = true, EmitDefaultValue = true)]
        public bool Noticeable { get; set; }

        /// <summary>
        /// チャンネルの最古の未読メッセージの日時
        /// </summary>
        /// <value>チャンネルの最古の未読メッセージの日時</value>
        [DataMember(Name = "since", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Since { get; set; }

        /// <summary>
        /// チャンネルの最新の未読メッセージの日時
        /// </summary>
        /// <value>チャンネルの最新の未読メッセージの日時</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// そのチャンネルの未読の中で最も古いメッセージのid
        /// </summary>
        /// <value>そのチャンネルの未読の中で最も古いメッセージのid</value>
        [DataMember(Name = "oldestMessageId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OldestMessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnreadChannel {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Noticeable: ").Append(Noticeable).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  OldestMessageId: ").Append(OldestMessageId).Append("\n");
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
