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
    /// チャンネル名変更イベント
    /// </summary>
    [DataContract(Name = "NameChangedEvent")]
    public partial class NameChangedEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameChangedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NameChangedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NameChangedEvent" /> class.
        /// </summary>
        /// <param name="userId">変更者UUID (required).</param>
        /// <param name="before">変更前チャンネル名 (required).</param>
        /// <param name="after">変更後チャンネル名 (required).</param>
        public NameChangedEvent(Guid userId = default(Guid), string before = default(string), string after = default(string))
        {
            this.UserId = userId;
            // to ensure "before" is required (not null)
            if (before == null)
            {
                throw new ArgumentNullException("before is a required property for NameChangedEvent and cannot be null");
            }
            this.Before = before;
            // to ensure "after" is required (not null)
            if (after == null)
            {
                throw new ArgumentNullException("after is a required property for NameChangedEvent and cannot be null");
            }
            this.After = after;
        }

        /// <summary>
        /// 変更者UUID
        /// </summary>
        /// <value>変更者UUID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// 変更前チャンネル名
        /// </summary>
        /// <value>変更前チャンネル名</value>
        [DataMember(Name = "before", IsRequired = true, EmitDefaultValue = true)]
        public string Before { get; set; }

        /// <summary>
        /// 変更後チャンネル名
        /// </summary>
        /// <value>変更後チャンネル名</value>
        [DataMember(Name = "after", IsRequired = true, EmitDefaultValue = true)]
        public string After { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NameChangedEvent {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
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