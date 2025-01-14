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
    /// GET /channelsレスポンス
    /// </summary>
    [DataContract(Name = "ChannelList")]
    public partial class ChannelList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelList" /> class.
        /// </summary>
        /// <param name="varPublic">パブリックチャンネルの配列 (required).</param>
        /// <param name="dm">ダイレクトメッセージチャンネルの配列.</param>
        public ChannelList(List<Channel> varPublic = default(List<Channel>), List<DMChannel> dm = default(List<DMChannel>))
        {
            // to ensure "varPublic" is required (not null)
            if (varPublic == null)
            {
                throw new ArgumentNullException("varPublic is a required property for ChannelList and cannot be null");
            }
            this.Public = varPublic;
            this.Dm = dm;
        }

        /// <summary>
        /// パブリックチャンネルの配列
        /// </summary>
        /// <value>パブリックチャンネルの配列</value>
        [DataMember(Name = "public", IsRequired = true, EmitDefaultValue = true)]
        public List<Channel> Public { get; set; }

        /// <summary>
        /// ダイレクトメッセージチャンネルの配列
        /// </summary>
        /// <value>ダイレクトメッセージチャンネルの配列</value>
        [DataMember(Name = "dm", EmitDefaultValue = false)]
        public List<DMChannel> Dm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelList {\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Dm: ").Append(Dm).Append("\n");
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