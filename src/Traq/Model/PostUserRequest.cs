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
    /// ユーザー登録リクエスト
    /// </summary>
    [DataContract(Name = "PostUserRequest")]
    public partial class PostUserRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUserRequest" /> class.
        /// </summary>
        /// <param name="name">ユーザー名 (required).</param>
        /// <param name="password">パスワード.</param>
        public PostUserRequest(string name = default(string), string password = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PostUserRequest and cannot be null");
            }
            this.Name = name;
            this.Password = password;
        }

        /// <summary>
        /// ユーザー名
        /// </summary>
        /// <value>ユーザー名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        /// <value>パスワード</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostUserRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@"^[a-zA-Z0-9_-]{1,32}$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            if (this.Password != null) {
                // Password (string) pattern
                Regex regexPassword = new Regex(@"^[\x20-\x7E]{10,32}$", RegexOptions.CultureInvariant);
                if (!regexPassword.Match(this.Password).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, must match a pattern of " + regexPassword, new [] { "Password" });
                }
            }

            yield break;
        }
    }

}
