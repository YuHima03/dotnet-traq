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
    /// ユーザーグループメンバー編集リクエスト
    /// </summary>
    [DataContract(Name = "PatchGroupMemberRequest")]
    public partial class PatchGroupMemberRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchGroupMemberRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchGroupMemberRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchGroupMemberRequest" /> class.
        /// </summary>
        /// <param name="role">ユーザーの役割 (required).</param>
        public PatchGroupMemberRequest(string role = default(string))
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for PatchGroupMemberRequest and cannot be null");
            }
            this.Role = role;
        }

        /// <summary>
        /// ユーザーの役割
        /// </summary>
        /// <value>ユーザーの役割</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchGroupMemberRequest {\n");
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
            // Role (string) maxLength
            if (this.Role != null && this.Role.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Role, length must be less than 100.", new [] { "Role" });
            }

            yield break;
        }
    }

}