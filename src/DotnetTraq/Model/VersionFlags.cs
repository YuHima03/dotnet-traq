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
    /// VersionFlags
    /// </summary>
    [DataContract(Name = "Version_flags")]
    public partial class VersionFlags : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionFlags" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VersionFlags() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionFlags" /> class.
        /// </summary>
        /// <param name="externalLogin">有効な外部ログインプロバイダ (required).</param>
        /// <param name="signUpAllowed">ユーザーが自身で新規登録(POST /api/v3/users)可能か (required).</param>
        public VersionFlags(List<string> externalLogin = default(List<string>), bool signUpAllowed = default(bool))
        {
            // to ensure "externalLogin" is required (not null)
            if (externalLogin == null)
            {
                throw new ArgumentNullException("externalLogin is a required property for VersionFlags and cannot be null");
            }
            this.ExternalLogin = externalLogin;
            this.SignUpAllowed = signUpAllowed;
        }

        /// <summary>
        /// 有効な外部ログインプロバイダ
        /// </summary>
        /// <value>有効な外部ログインプロバイダ</value>
        [DataMember(Name = "externalLogin", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ExternalLogin { get; set; }

        /// <summary>
        /// ユーザーが自身で新規登録(POST /api/v3/users)可能か
        /// </summary>
        /// <value>ユーザーが自身で新規登録(POST /api/v3/users)可能か</value>
        [DataMember(Name = "signUpAllowed", IsRequired = true, EmitDefaultValue = true)]
        public bool SignUpAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VersionFlags {\n");
            sb.Append("  ExternalLogin: ").Append(ExternalLogin).Append("\n");
            sb.Append("  SignUpAllowed: ").Append(SignUpAllowed).Append("\n");
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