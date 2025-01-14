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
    /// ログインセッション情報
    /// </summary>
    [DataContract(Name = "LoginSession")]
    public partial class LoginSession : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoginSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSession" /> class.
        /// </summary>
        /// <param name="id">セッションUUID (required).</param>
        /// <param name="issuedAt">発行日時 (required).</param>
        public LoginSession(Guid id = default(Guid), DateTimeOffset issuedAt = default(DateTimeOffset))
        {
            this.Id = id;
            this.IssuedAt = issuedAt;
        }

        /// <summary>
        /// セッションUUID
        /// </summary>
        /// <value>セッションUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// 発行日時
        /// </summary>
        /// <value>発行日時</value>
        [DataMember(Name = "issuedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset IssuedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoginSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
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
