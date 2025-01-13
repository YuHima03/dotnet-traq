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
    /// ダイレクトメッセージチャンネル
    /// </summary>
    [DataContract(Name = "DMChannel")]
    public partial class DMChannel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DMChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DMChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DMChannel" /> class.
        /// </summary>
        /// <param name="id">チャンネルUUID (required).</param>
        /// <param name="userId">送信先相手のUUID (required).</param>
        public DMChannel(Guid id = default(Guid), Guid userId = default(Guid))
        {
            this.Id = id;
            this.UserId = userId;
        }

        /// <summary>
        /// チャンネルUUID
        /// </summary>
        /// <value>チャンネルUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// 送信先相手のUUID
        /// </summary>
        /// <value>送信先相手のUUID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DMChannel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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