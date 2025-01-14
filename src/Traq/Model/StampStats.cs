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
    /// スタンプ統計情報
    /// </summary>
    [DataContract(Name = "StampStats")]
    public partial class StampStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StampStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StampStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StampStats" /> class.
        /// </summary>
        /// <param name="count">スタンプ使用総数(同じユーザによって同じメッセージに貼られたものは複数カウントしない) (required).</param>
        /// <param name="totalCount">スタンプ使用総数(全てカウント) (required).</param>
        public StampStats(long count = default(long), long totalCount = default(long))
        {
            this.Count = count;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// スタンプ使用総数(同じユーザによって同じメッセージに貼られたものは複数カウントしない)
        /// </summary>
        /// <value>スタンプ使用総数(同じユーザによって同じメッセージに貼られたものは複数カウントしない)</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public long Count { get; set; }

        /// <summary>
        /// スタンプ使用総数(全てカウント)
        /// </summary>
        /// <value>スタンプ使用総数(全てカウント)</value>
        [DataMember(Name = "totalCount", IsRequired = true, EmitDefaultValue = true)]
        public long TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StampStats {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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