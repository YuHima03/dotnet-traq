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
    /// 外部認証アカウントユーザー
    /// </summary>
    [DataContract(Name = "ExternalProviderUser")]
    public partial class ExternalProviderUser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalProviderUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalProviderUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalProviderUser" /> class.
        /// </summary>
        /// <param name="providerName">外部サービス名 (required).</param>
        /// <param name="linkedAt">紐付けた日時 (required).</param>
        /// <param name="externalName">外部アカウント名 (required).</param>
        public ExternalProviderUser(string providerName = default(string), string linkedAt = default(string), string externalName = default(string))
        {
            // to ensure "providerName" is required (not null)
            if (providerName == null)
            {
                throw new ArgumentNullException("providerName is a required property for ExternalProviderUser and cannot be null");
            }
            this.ProviderName = providerName;
            // to ensure "linkedAt" is required (not null)
            if (linkedAt == null)
            {
                throw new ArgumentNullException("linkedAt is a required property for ExternalProviderUser and cannot be null");
            }
            this.LinkedAt = linkedAt;
            // to ensure "externalName" is required (not null)
            if (externalName == null)
            {
                throw new ArgumentNullException("externalName is a required property for ExternalProviderUser and cannot be null");
            }
            this.ExternalName = externalName;
        }

        /// <summary>
        /// 外部サービス名
        /// </summary>
        /// <value>外部サービス名</value>
        [DataMember(Name = "providerName", IsRequired = true, EmitDefaultValue = true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 紐付けた日時
        /// </summary>
        /// <value>紐付けた日時</value>
        [DataMember(Name = "linkedAt", IsRequired = true, EmitDefaultValue = true)]
        public string LinkedAt { get; set; }

        /// <summary>
        /// 外部アカウント名
        /// </summary>
        /// <value>外部アカウント名</value>
        [DataMember(Name = "externalName", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExternalProviderUser {\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  LinkedAt: ").Append(LinkedAt).Append("\n");
            sb.Append("  ExternalName: ").Append(ExternalName).Append("\n");
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
