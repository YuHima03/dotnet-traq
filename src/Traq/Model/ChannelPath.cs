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
    /// チャンネルパス
    /// </summary>
    [DataContract(Name = "ChannelPath")]
    public partial class ChannelPath : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPath" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelPath() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPath" /> class.
        /// </summary>
        /// <param name="path">チャンネルパス (required).</param>
        public ChannelPath(string path = default(string))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for ChannelPath and cannot be null");
            }
            this.Path = path;
        }

        /// <summary>
        /// チャンネルパス
        /// </summary>
        /// <value>チャンネルパス</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelPath {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            if (this.Path != null) {
                // Path (string) pattern
                Regex regexPath = new Regex(@"^(\/[a-zA-Z0-9-_]+)+$", RegexOptions.CultureInvariant);
                if (!regexPath.Match(this.Path).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Path, must match a pattern of " + regexPath, new [] { "Path" });
                }
            }

            yield break;
        }
    }

}
