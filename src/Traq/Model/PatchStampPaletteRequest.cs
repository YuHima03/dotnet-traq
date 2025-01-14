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
    /// スタンプパレット情報変更リクエスト
    /// </summary>
    [DataContract(Name = "PatchStampPaletteRequest")]
    public partial class PatchStampPaletteRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchStampPaletteRequest" /> class.
        /// </summary>
        /// <param name="name">パレット名.</param>
        /// <param name="description">説明.</param>
        /// <param name="stamps">パレット内のスタンプUUIDの配列.</param>
        public PatchStampPaletteRequest(string name = default(string), string description = default(string), List<Guid> stamps = default(List<Guid>))
        {
            this.Name = name;
            this.Description = description;
            this.Stamps = stamps;
        }

        /// <summary>
        /// パレット名
        /// </summary>
        /// <value>パレット名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        /// <value>説明</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// パレット内のスタンプUUIDの配列
        /// </summary>
        /// <value>パレット内のスタンプUUIDの配列</value>
        [DataMember(Name = "stamps", EmitDefaultValue = false)]
        public List<Guid> Stamps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchStampPaletteRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Stamps: ").Append(Stamps).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 30)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 30.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            yield break;
        }
    }

}
