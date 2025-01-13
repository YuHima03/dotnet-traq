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
    /// OAuth2Token
    /// </summary>
    [DataContract(Name = "OAuth2Token")]
    public partial class OAuth2Token : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Token" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuth2Token() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Token" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken (required).</param>
        /// <param name="tokenType">tokenType (required).</param>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="scope">scope.</param>
        /// <param name="idToken">idToken.</param>
        public OAuth2Token(string accessToken = default(string), string tokenType = default(string), int expiresIn = default(int), string refreshToken = default(string), string scope = default(string), string idToken = default(string))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new ArgumentNullException("accessToken is a required property for OAuth2Token and cannot be null");
            }
            this.AccessToken = accessToken;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for OAuth2Token and cannot be null");
            }
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.IdToken = idToken;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", IsRequired = true, EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name = "id_token", EmitDefaultValue = false)]
        public string IdToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuth2Token {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
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