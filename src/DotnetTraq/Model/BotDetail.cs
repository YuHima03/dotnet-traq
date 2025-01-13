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
using FileParameter = DotnetTraq.Client.FileParameter;
using OpenAPIDateConverter = DotnetTraq.Client.OpenAPIDateConverter;

namespace DotnetTraq.Model
{
    /// <summary>
    /// BOT詳細情報
    /// </summary>
    [DataContract(Name = "BotDetail")]
    public partial class BotDetail : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public BotMode Mode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public BotState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotDetail" /> class.
        /// </summary>
        /// <param name="id">BOT UUID (required).</param>
        /// <param name="updatedAt">更新日時 (required).</param>
        /// <param name="createdAt">作成日時 (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="subscribeEvents">BOTが購読しているイベントの配列 (required).</param>
        /// <param name="developerId">BOT開発者UUID (required).</param>
        /// <param name="description">説明 (required).</param>
        /// <param name="botUserId">BOTユーザーUUID (required).</param>
        /// <param name="tokens">tokens (required).</param>
        /// <param name="endpoint">BOTサーバーエンドポイント (required).</param>
        /// <param name="privileged">特権BOTかどうか (required).</param>
        /// <param name="channels">BOTが参加しているチャンネルのUUID配列 (required).</param>
        public BotDetail(Guid id = default(Guid), DateTimeOffset updatedAt = default(DateTimeOffset), DateTimeOffset createdAt = default(DateTimeOffset), BotMode mode = default(BotMode), BotState state = default(BotState), List<string> subscribeEvents = default(List<string>), Guid developerId = default(Guid), string description = default(string), Guid botUserId = default(Guid), BotTokens tokens = default(BotTokens), string endpoint = default(string), bool privileged = default(bool), List<Guid> channels = default(List<Guid>))
        {
            this.Id = id;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Mode = mode;
            this.State = state;
            // to ensure "subscribeEvents" is required (not null)
            if (subscribeEvents == null)
            {
                throw new ArgumentNullException("subscribeEvents is a required property for BotDetail and cannot be null");
            }
            this.SubscribeEvents = subscribeEvents;
            this.DeveloperId = developerId;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for BotDetail and cannot be null");
            }
            this.Description = description;
            this.BotUserId = botUserId;
            // to ensure "tokens" is required (not null)
            if (tokens == null)
            {
                throw new ArgumentNullException("tokens is a required property for BotDetail and cannot be null");
            }
            this.Tokens = tokens;
            // to ensure "endpoint" is required (not null)
            if (endpoint == null)
            {
                throw new ArgumentNullException("endpoint is a required property for BotDetail and cannot be null");
            }
            this.Endpoint = endpoint;
            this.Privileged = privileged;
            // to ensure "channels" is required (not null)
            if (channels == null)
            {
                throw new ArgumentNullException("channels is a required property for BotDetail and cannot be null");
            }
            this.Channels = channels;
        }

        /// <summary>
        /// BOT UUID
        /// </summary>
        /// <value>BOT UUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        /// <value>更新日時</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// 作成日時
        /// </summary>
        /// <value>作成日時</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// BOTが購読しているイベントの配列
        /// </summary>
        /// <value>BOTが購読しているイベントの配列</value>
        [DataMember(Name = "subscribeEvents", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SubscribeEvents { get; set; }

        /// <summary>
        /// BOT開発者UUID
        /// </summary>
        /// <value>BOT開発者UUID</value>
        [DataMember(Name = "developerId", IsRequired = true, EmitDefaultValue = true)]
        public Guid DeveloperId { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        /// <value>説明</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// BOTユーザーUUID
        /// </summary>
        /// <value>BOTユーザーUUID</value>
        [DataMember(Name = "botUserId", IsRequired = true, EmitDefaultValue = true)]
        public Guid BotUserId { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name = "tokens", IsRequired = true, EmitDefaultValue = true)]
        public BotTokens Tokens { get; set; }

        /// <summary>
        /// BOTサーバーエンドポイント
        /// </summary>
        /// <value>BOTサーバーエンドポイント</value>
        [DataMember(Name = "endpoint", IsRequired = true, EmitDefaultValue = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 特権BOTかどうか
        /// </summary>
        /// <value>特権BOTかどうか</value>
        [DataMember(Name = "privileged", IsRequired = true, EmitDefaultValue = true)]
        public bool Privileged { get; set; }

        /// <summary>
        /// BOTが参加しているチャンネルのUUID配列
        /// </summary>
        /// <value>BOTが参加しているチャンネルのUUID配列</value>
        [DataMember(Name = "channels", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Channels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BotDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscribeEvents: ").Append(SubscribeEvents).Append("\n");
            sb.Append("  DeveloperId: ").Append(DeveloperId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BotUserId: ").Append(BotUserId).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Privileged: ").Append(Privileged).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            yield break;
        }
    }

}