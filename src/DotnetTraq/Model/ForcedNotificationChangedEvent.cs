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
    /// チャンネル強制通知状態変更イベント
    /// </summary>
    [DataContract(Name = "ForcedNotificationChangedEvent")]
    public partial class ForcedNotificationChangedEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedNotificationChangedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForcedNotificationChangedEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedNotificationChangedEvent" /> class.
        /// </summary>
        /// <param name="userId">変更者UUID (required).</param>
        /// <param name="force">変更後強制通知状態 (required).</param>
        public ForcedNotificationChangedEvent(Guid userId = default(Guid), bool force = default(bool))
        {
            this.UserId = userId;
            this.Force = force;
        }

        /// <summary>
        /// 変更者UUID
        /// </summary>
        /// <value>変更者UUID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// 変更後強制通知状態
        /// </summary>
        /// <value>変更後強制通知状態</value>
        [DataMember(Name = "force", IsRequired = true, EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForcedNotificationChangedEvent {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
