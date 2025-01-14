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
    /// BOT情報
    /// </summary>
    [DataContract(Name = "Bot")]
    public partial class Bot : IValidatableObject
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
        /// Initializes a new instance of the <see cref="Bot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Bot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bot" /> class.
        /// </summary>
        /// <param name="id">BOT UUID (required).</param>
        /// <param name="botUserId">BOTユーザーUUID (required).</param>
        /// <param name="description">説明 (required).</param>
        /// <param name="developerId">BOT開発者UUID (required).</param>
        /// <param name="subscribeEvents">BOTが購読しているイベントの配列 (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="createdAt">作成日時 (required).</param>
        /// <param name="updatedAt">更新日時 (required).</param>
        public Bot(Guid id = default(Guid), Guid botUserId = default(Guid), string description = default(string), Guid developerId = default(Guid), List<string> subscribeEvents = default(List<string>), BotMode mode = default(BotMode), BotState state = default(BotState), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset))
        {
            this.Id = id;
            this.BotUserId = botUserId;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Bot and cannot be null");
            }
            this.Description = description;
            this.DeveloperId = developerId;
            // to ensure "subscribeEvents" is required (not null)
            if (subscribeEvents == null)
            {
                throw new ArgumentNullException("subscribeEvents is a required property for Bot and cannot be null");
            }
            this.SubscribeEvents = subscribeEvents;
            this.Mode = mode;
            this.State = state;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// BOT UUID
        /// </summary>
        /// <value>BOT UUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// BOTユーザーUUID
        /// </summary>
        /// <value>BOTユーザーUUID</value>
        [DataMember(Name = "botUserId", IsRequired = true, EmitDefaultValue = true)]
        public Guid BotUserId { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        /// <value>説明</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// BOT開発者UUID
        /// </summary>
        /// <value>BOT開発者UUID</value>
        [DataMember(Name = "developerId", IsRequired = true, EmitDefaultValue = true)]
        public Guid DeveloperId { get; set; }

        /// <summary>
        /// BOTが購読しているイベントの配列
        /// </summary>
        /// <value>BOTが購読しているイベントの配列</value>
        [DataMember(Name = "subscribeEvents", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SubscribeEvents { get; set; }

        /// <summary>
        /// 作成日時
        /// </summary>
        /// <value>作成日時</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        /// <value>更新日時</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bot {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BotUserId: ").Append(BotUserId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeveloperId: ").Append(DeveloperId).Append("\n");
            sb.Append("  SubscribeEvents: ").Append(SubscribeEvents).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            yield break;
        }
    }

}
