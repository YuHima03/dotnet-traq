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
    /// OAuth2クライアント情報変更リクエスト
    /// </summary>
    [DataContract(Name = "PatchClientRequest")]
    public partial class PatchClientRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchClientRequest" /> class.
        /// </summary>
        /// <param name="name">クライアント名.</param>
        /// <param name="description">説明.</param>
        /// <param name="callbackUrl">コールバックURL.</param>
        /// <param name="developerId">クライアント開発者UUID.</param>
        /// <param name="confidential">confidential client なら true, public client なら false.</param>
        public PatchClientRequest(string name = default(string), string description = default(string), string callbackUrl = default(string), Guid developerId = default(Guid), bool confidential = default(bool))
        {
            this.Name = name;
            this.Description = description;
            this.CallbackUrl = callbackUrl;
            this.DeveloperId = developerId;
            this.Confidential = confidential;
        }

        /// <summary>
        /// クライアント名
        /// </summary>
        /// <value>クライアント名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        /// <value>説明</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// コールバックURL
        /// </summary>
        /// <value>コールバックURL</value>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// クライアント開発者UUID
        /// </summary>
        /// <value>クライアント開発者UUID</value>
        [DataMember(Name = "developerId", EmitDefaultValue = false)]
        public Guid DeveloperId { get; set; }

        /// <summary>
        /// confidential client なら true, public client なら false
        /// </summary>
        /// <value>confidential client なら true, public client なら false</value>
        [DataMember(Name = "confidential", EmitDefaultValue = true)]
        public bool Confidential { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchClientRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  DeveloperId: ").Append(DeveloperId).Append("\n");
            sb.Append("  Confidential: ").Append(Confidential).Append("\n");
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

            yield break;
        }
    }

}
