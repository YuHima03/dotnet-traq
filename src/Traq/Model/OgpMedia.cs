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
    /// OGPに含まれる画像の情報
    /// </summary>
    [DataContract(Name = "OgpMedia")]
    public partial class OgpMedia : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OgpMedia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OgpMedia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OgpMedia" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="secureUrl">secureUrl (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="width">width (required).</param>
        /// <param name="height">height (required).</param>
        public OgpMedia(string url = default(string), string secureUrl = default(string), string type = default(string), int? width = default(int?), int? height = default(int?))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for OgpMedia and cannot be null");
            }
            this.Url = url;
            // to ensure "secureUrl" is required (not null)
            if (secureUrl == null)
            {
                throw new ArgumentNullException("secureUrl is a required property for OgpMedia and cannot be null");
            }
            this.SecureUrl = secureUrl;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for OgpMedia and cannot be null");
            }
            this.Type = type;
            // to ensure "width" is required (not null)
            if (width == null)
            {
                throw new ArgumentNullException("width is a required property for OgpMedia and cannot be null");
            }
            this.Width = width;
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new ArgumentNullException("height is a required property for OgpMedia and cannot be null");
            }
            this.Height = height;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SecureUrl
        /// </summary>
        [DataMember(Name = "secureUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SecureUrl { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", IsRequired = true, EmitDefaultValue = true)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = true)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OgpMedia {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SecureUrl: ").Append(SecureUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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