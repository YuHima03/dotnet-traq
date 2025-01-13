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
    /// FCMデバイス登録リクエスト
    /// </summary>
    [DataContract(Name = "PostMyFCMDeviceRequest")]
    public partial class PostMyFCMDeviceRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostMyFCMDeviceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostMyFCMDeviceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostMyFCMDeviceRequest" /> class.
        /// </summary>
        /// <param name="token">FCMのデバイストークン (required).</param>
        public PostMyFCMDeviceRequest(string token = default(string))
        {
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for PostMyFCMDeviceRequest and cannot be null");
            }
            this.Token = token;
        }

        /// <summary>
        /// FCMのデバイストークン
        /// </summary>
        /// <value>FCMのデバイストークン</value>
        /*
        <example>bk3RNwTe3H0:CI2k_HHwgIpoDKCIZvvDMExUdFQ3P1</example>
        */
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostMyFCMDeviceRequest {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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