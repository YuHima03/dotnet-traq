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
    /// グループ管理者追加リクエスト
    /// </summary>
    [DataContract(Name = "PostUserGroupAdminRequest")]
    public partial class PostUserGroupAdminRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUserGroupAdminRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostUserGroupAdminRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUserGroupAdminRequest" /> class.
        /// </summary>
        /// <param name="id">追加するユーザーのUUID (required).</param>
        public PostUserGroupAdminRequest(Guid id = default(Guid))
        {
            this.Id = id;
        }

        /// <summary>
        /// 追加するユーザーのUUID
        /// </summary>
        /// <value>追加するユーザーのUUID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostUserGroupAdminRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
