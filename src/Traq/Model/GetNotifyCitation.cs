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
    /// メッセージ引用通知の設定情報
    /// </summary>
    [DataContract(Name = "GetNotifyCitation")]
    public partial class GetNotifyCitation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotifyCitation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetNotifyCitation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotifyCitation" /> class.
        /// </summary>
        /// <param name="notifyCitation">notifyCitation (required).</param>
        public GetNotifyCitation(bool notifyCitation = default(bool))
        {
            this.NotifyCitation = notifyCitation;
        }

        /// <summary>
        /// Gets or Sets NotifyCitation
        /// </summary>
        [DataMember(Name = "notifyCitation", IsRequired = true, EmitDefaultValue = true)]
        public bool NotifyCitation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetNotifyCitation {\n");
            sb.Append("  NotifyCitation: ").Append(NotifyCitation).Append("\n");
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