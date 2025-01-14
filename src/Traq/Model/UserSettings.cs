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
    /// ユーザー設定の情報
    /// </summary>
    [DataContract(Name = "UserSettings")]
    public partial class UserSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettings" /> class.
        /// </summary>
        /// <param name="id">ユーザーUUID (required).</param>
        /// <param name="notifyCitation">メッセージ引用通知の設定情報 (required).</param>
        public UserSettings(Guid id = default(Guid), bool notifyCitation = default(bool))
        {
            this.Id = id;
            this.NotifyCitation = notifyCitation;
        }

        /// <summary>
        /// ユーザーUUID
        /// </summary>
        /// <value>ユーザーUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// メッセージ引用通知の設定情報
        /// </summary>
        /// <value>メッセージ引用通知の設定情報</value>
        [DataMember(Name = "notifyCitation", IsRequired = true, EmitDefaultValue = true)]
        public bool NotifyCitation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSettings {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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