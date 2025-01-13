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
    /// BOT作成リクエスト
    /// </summary>
    [DataContract(Name = "PostBotRequest")]
    public partial class PostBotRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public BotMode Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostBotRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostBotRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostBotRequest" /> class.
        /// </summary>
        /// <param name="name">BOTユーザーID 自動的に接頭辞\&quot;BOT_\&quot;が付与されます (required).</param>
        /// <param name="displayName">BOTユーザー表示名 (required).</param>
        /// <param name="description">BOTの説明 (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="endpoint">BOTサーバーエンドポイント BOT動作モードがHTTPの場合必須です.</param>
        public PostBotRequest(string name = default(string), string displayName = default(string), string description = default(string), BotMode mode = default(BotMode), string endpoint = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PostBotRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for PostBotRequest and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for PostBotRequest and cannot be null");
            }
            this.Description = description;
            this.Mode = mode;
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// BOTユーザーID 自動的に接頭辞\&quot;BOT_\&quot;が付与されます
        /// </summary>
        /// <value>BOTユーザーID 自動的に接頭辞\&quot;BOT_\&quot;が付与されます</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// BOTユーザー表示名
        /// </summary>
        /// <value>BOTユーザー表示名</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// BOTの説明
        /// </summary>
        /// <value>BOTの説明</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// BOTサーバーエンドポイント BOT動作モードがHTTPの場合必須です
        /// </summary>
        /// <value>BOTサーバーエンドポイント BOT動作モードがHTTPの場合必須です</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostBotRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
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
            if (this.Name != null && this.Name.Length > 16)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 16.", new [] { "Name" });
            }

            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@"^[a-zA-Z0-9_-]{1,16}$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 32)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 32.", new [] { "DisplayName" });
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
