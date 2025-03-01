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
    /// skyway用認証リクエスト
    /// </summary>
    [DataContract(Name = "PostWebRTCAuthenticateRequest")]
    public partial class PostWebRTCAuthenticateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebRTCAuthenticateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostWebRTCAuthenticateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebRTCAuthenticateRequest" /> class.
        /// </summary>
        /// <param name="peerId">ピアID (required).</param>
        public PostWebRTCAuthenticateRequest(string peerId = default(string))
        {
            // to ensure "peerId" is required (not null)
            if (peerId == null)
            {
                throw new ArgumentNullException("peerId is a required property for PostWebRTCAuthenticateRequest and cannot be null");
            }
            this.PeerId = peerId;
        }

        /// <summary>
        /// ピアID
        /// </summary>
        /// <value>ピアID</value>
        [DataMember(Name = "peerId", IsRequired = true, EmitDefaultValue = true)]
        public string PeerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostWebRTCAuthenticateRequest {\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
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
