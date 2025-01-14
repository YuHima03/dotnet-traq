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
    /// チャンネル上の特定スタンプ統計情報
    /// </summary>
    [DataContract(Name = "ChannelStatsStamp")]
    public partial class ChannelStatsStamp : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStatsStamp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelStatsStamp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStatsStamp" /> class.
        /// </summary>
        /// <param name="id">スタンプID (required).</param>
        /// <param name="count">スタンプ数(同一メッセージ上のものは複数カウントしない) (required).</param>
        /// <param name="total">スタンプ数(同一メッセージ上のものも複数カウントする) (required).</param>
        public ChannelStatsStamp(Guid id = default(Guid), long count = default(long), long total = default(long))
        {
            this.Id = id;
            this.Count = count;
            this.Total = total;
        }

        /// <summary>
        /// スタンプID
        /// </summary>
        /// <value>スタンプID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// スタンプ数(同一メッセージ上のものは複数カウントしない)
        /// </summary>
        /// <value>スタンプ数(同一メッセージ上のものは複数カウントしない)</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public long Count { get; set; }

        /// <summary>
        /// スタンプ数(同一メッセージ上のものも複数カウントする)
        /// </summary>
        /// <value>スタンプ数(同一メッセージ上のものも複数カウントする)</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public long Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelStatsStamp {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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