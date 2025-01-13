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
    /// メッセージクリップ
    /// </summary>
    [DataContract(Name = "MessageClip")]
    public partial class MessageClip : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageClip" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageClip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageClip" /> class.
        /// </summary>
        /// <param name="folderId">クリップされているフォルダのID (required).</param>
        /// <param name="clippedAt">クリップされた日時 (required).</param>
        public MessageClip(Guid folderId = default(Guid), DateTimeOffset clippedAt = default(DateTimeOffset))
        {
            this.FolderId = folderId;
            this.ClippedAt = clippedAt;
        }

        /// <summary>
        /// クリップされているフォルダのID
        /// </summary>
        /// <value>クリップされているフォルダのID</value>
        [DataMember(Name = "folderId", IsRequired = true, EmitDefaultValue = true)]
        public Guid FolderId { get; set; }

        /// <summary>
        /// クリップされた日時
        /// </summary>
        /// <value>クリップされた日時</value>
        [DataMember(Name = "clippedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ClippedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageClip {\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  ClippedAt: ").Append(ClippedAt).Append("\n");
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