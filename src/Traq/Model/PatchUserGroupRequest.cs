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
    /// ユーザーグループ編集リクエスト
    /// </summary>
    [DataContract(Name = "PatchUserGroupRequest")]
    public partial class PatchUserGroupRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUserGroupRequest" /> class.
        /// </summary>
        /// <param name="name">グループ名.</param>
        /// <param name="description">グループ説明.</param>
        /// <param name="type">グループタイプ.</param>
        public PatchUserGroupRequest(string name = default(string), string description = default(string), string type = default(string))
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
        }

        /// <summary>
        /// グループ名
        /// </summary>
        /// <value>グループ名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// グループ説明
        /// </summary>
        /// <value>グループ説明</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// グループタイプ
        /// </summary>
        /// <value>グループタイプ</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchUserGroupRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            if (this.Description != null && this.Description.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 100.", new [] { "Description" });
            }

            yield break;
        }
    }

}
