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
    /// 親チャンネル変更イベント
    /// </summary>
    [DataContract(Name = "ParentChangedEvent")]
    public partial class ParentChangedEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentChangedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParentChangedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentChangedEvent" /> class.
        /// </summary>
        /// <param name="userId">変更者UUID (required).</param>
        /// <param name="before">変更前親チャンネルUUID (required).</param>
        /// <param name="after">変更後親チャンネルUUID (required).</param>
        public ParentChangedEvent(Guid userId = default(Guid), Guid before = default(Guid), Guid after = default(Guid))
        {
            this.UserId = userId;
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// 変更者UUID
        /// </summary>
        /// <value>変更者UUID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// 変更前親チャンネルUUID
        /// </summary>
        /// <value>変更前親チャンネルUUID</value>
        [DataMember(Name = "before", IsRequired = true, EmitDefaultValue = true)]
        public Guid Before { get; set; }

        /// <summary>
        /// 変更後親チャンネルUUID
        /// </summary>
        /// <value>変更後親チャンネルUUID</value>
        [DataMember(Name = "after", IsRequired = true, EmitDefaultValue = true)]
        public Guid After { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParentChangedEvent {\n");
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
