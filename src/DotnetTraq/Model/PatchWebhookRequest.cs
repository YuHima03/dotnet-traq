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
    /// Webhook情報変更リクエスト
    /// </summary>
    [DataContract(Name = "PatchWebhookRequest")]
    public partial class PatchWebhookRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookRequest" /> class.
        /// </summary>
        /// <param name="name">Webhookユーザー表示名.</param>
        /// <param name="description">説明.</param>
        /// <param name="channelId">デフォルトの投稿先チャンネルUUID.</param>
        /// <param name="secret">Webhookシークレット.</param>
        /// <param name="ownerId">移譲先のユーザーUUID.</param>
        public PatchWebhookRequest(string name = default(string), string description = default(string), Guid channelId = default(Guid), string secret = default(string), Guid ownerId = default(Guid))
        {
            this.Name = name;
            this.Description = description;
            this.ChannelId = channelId;
            this.Secret = secret;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Webhookユーザー表示名
        /// </summary>
        /// <value>Webhookユーザー表示名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        /// <value>説明</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// デフォルトの投稿先チャンネルUUID
        /// </summary>
        /// <value>デフォルトの投稿先チャンネルUUID</value>
        [DataMember(Name = "channelId", EmitDefaultValue = false)]
        public Guid ChannelId { get; set; }

        /// <summary>
        /// Webhookシークレット
        /// </summary>
        /// <value>Webhookシークレット</value>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// 移譲先のユーザーUUID
        /// </summary>
        /// <value>移譲先のユーザーUUID</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchWebhookRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 32)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 32.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            // Secret (string) maxLength
            if (this.Secret != null && this.Secret.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Secret, length must be less than 50.", new [] { "Secret" });
            }

            yield break;
        }
    }

}
