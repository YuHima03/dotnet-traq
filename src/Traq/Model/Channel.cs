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
    /// チャンネル
    /// </summary>
    [DataContract(Name = "Channel")]
    public partial class Channel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Channel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="id">チャンネルUUID (required).</param>
        /// <param name="parentId">親チャンネルUUID (required).</param>
        /// <param name="archived">チャンネルがアーカイブされているかどうか (required).</param>
        /// <param name="force">強制通知チャンネルかどうか (required).</param>
        /// <param name="topic">チャンネルトピック (required).</param>
        /// <param name="name">チャンネル名 (required).</param>
        /// <param name="children">子チャンネルのUUID配列 (required).</param>
        public Channel(Guid id = default(Guid), Guid? parentId = default(Guid?), bool archived = default(bool), bool force = default(bool), string topic = default(string), string name = default(string), List<Guid> children = default(List<Guid>))
        {
            this.Id = id;
            // to ensure "parentId" is required (not null)
            if (parentId == null)
            {
                throw new ArgumentNullException("parentId is a required property for Channel and cannot be null");
            }
            this.ParentId = parentId;
            this.Archived = archived;
            this.Force = force;
            // to ensure "topic" is required (not null)
            if (topic == null)
            {
                throw new ArgumentNullException("topic is a required property for Channel and cannot be null");
            }
            this.Topic = topic;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Channel and cannot be null");
            }
            this.Name = name;
            // to ensure "children" is required (not null)
            if (children == null)
            {
                throw new ArgumentNullException("children is a required property for Channel and cannot be null");
            }
            this.Children = children;
        }

        /// <summary>
        /// チャンネルUUID
        /// </summary>
        /// <value>チャンネルUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// 親チャンネルUUID
        /// </summary>
        /// <value>親チャンネルUUID</value>
        [DataMember(Name = "parentId", IsRequired = true, EmitDefaultValue = true)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// チャンネルがアーカイブされているかどうか
        /// </summary>
        /// <value>チャンネルがアーカイブされているかどうか</value>
        [DataMember(Name = "archived", IsRequired = true, EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// 強制通知チャンネルかどうか
        /// </summary>
        /// <value>強制通知チャンネルかどうか</value>
        [DataMember(Name = "force", IsRequired = true, EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// チャンネルトピック
        /// </summary>
        /// <value>チャンネルトピック</value>
        [DataMember(Name = "topic", IsRequired = true, EmitDefaultValue = true)]
        public string Topic { get; set; }

        /// <summary>
        /// チャンネル名
        /// </summary>
        /// <value>チャンネル名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// 子チャンネルのUUID配列
        /// </summary>
        /// <value>子チャンネルのUUID配列</value>
        [DataMember(Name = "children", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Channel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
                Regex regexName = new Regex(@"^[a-zA-Z0-9-_]{1,20}$", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            yield break;
        }
    }

}