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
    /// ユーザー情報編集リクエスト
    /// </summary>
    [DataContract(Name = "PatchUserRequest")]
    public partial class PatchUserRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public UserAccountState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUserRequest" /> class.
        /// </summary>
        /// <param name="displayName">新しい表示名.</param>
        /// <param name="twitterId">TwitterID.</param>
        /// <param name="state">state.</param>
        /// <param name="role">ユーザーロール.</param>
        public PatchUserRequest(string displayName = default(string), string twitterId = default(string), UserAccountState? state = default(UserAccountState?), string role = default(string))
        {
            this.DisplayName = displayName;
            this.TwitterId = twitterId;
            this.State = state;
            this.Role = role;
        }

        /// <summary>
        /// 新しい表示名
        /// </summary>
        /// <value>新しい表示名</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// TwitterID
        /// </summary>
        /// <value>TwitterID</value>
        [DataMember(Name = "twitterId", EmitDefaultValue = false)]
        public string TwitterId { get; set; }

        /// <summary>
        /// ユーザーロール
        /// </summary>
        /// <value>ユーザーロール</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchUserRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 32)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 32.", new [] { "DisplayName" });
            }

            if (this.TwitterId != null) {
                // TwitterId (string) pattern
                Regex regexTwitterId = new Regex(@"^[a-zA-Z0-9_]{1,15}$", RegexOptions.CultureInvariant);
                if (!regexTwitterId.Match(this.TwitterId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TwitterId, must match a pattern of " + regexTwitterId, new [] { "TwitterId" });
                }
            }

            yield break;
        }
    }

}
