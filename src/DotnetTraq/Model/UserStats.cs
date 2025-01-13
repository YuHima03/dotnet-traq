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
    /// ユーザー統計情報
    /// </summary>
    [DataContract(Name = "UserStats")]
    public partial class UserStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStats" /> class.
        /// </summary>
        /// <param name="totalMessageCount">ユーザーの総投稿メッセージ数(削除されたものも含む) (required).</param>
        /// <param name="stamps">ユーザーのスタンプ統計情報 (required).</param>
        /// <param name="datetime">統計情報日時 (required).</param>
        public UserStats(long totalMessageCount = default(long), List<UserStatsStamp> stamps = default(List<UserStatsStamp>), DateTimeOffset datetime = default(DateTimeOffset))
        {
            this.TotalMessageCount = totalMessageCount;
            // to ensure "stamps" is required (not null)
            if (stamps == null)
            {
                throw new ArgumentNullException("stamps is a required property for UserStats and cannot be null");
            }
            this.Stamps = stamps;
            this.Datetime = datetime;
        }

        /// <summary>
        /// ユーザーの総投稿メッセージ数(削除されたものも含む)
        /// </summary>
        /// <value>ユーザーの総投稿メッセージ数(削除されたものも含む)</value>
        [DataMember(Name = "totalMessageCount", IsRequired = true, EmitDefaultValue = true)]
        public long TotalMessageCount { get; set; }

        /// <summary>
        /// ユーザーのスタンプ統計情報
        /// </summary>
        /// <value>ユーザーのスタンプ統計情報</value>
        [DataMember(Name = "stamps", IsRequired = true, EmitDefaultValue = true)]
        public List<UserStatsStamp> Stamps { get; set; }

        /// <summary>
        /// 統計情報日時
        /// </summary>
        /// <value>統計情報日時</value>
        [DataMember(Name = "datetime", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Datetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserStats {\n");
            sb.Append("  TotalMessageCount: ").Append(TotalMessageCount).Append("\n");
            sb.Append("  Stamps: ").Append(Stamps).Append("\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
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
