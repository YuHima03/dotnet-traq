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
    /// BOTイベントログ
    /// </summary>
    [DataContract(Name = "BotEventLog")]
    public partial class BotEventLog : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public BotEventResult? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotEventLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotEventLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotEventLog" /> class.
        /// </summary>
        /// <param name="botId">BOT UUID (required).</param>
        /// <param name="requestId">リクエストUUID (required).</param>
        /// <param name="varEvent">イベントタイプ (required).</param>
        /// <param name="result">result.</param>
        /// <param name="code">ステータスコード (required).</param>
        /// <param name="datetime">イベント日時 (required).</param>
        public BotEventLog(Guid botId = default(Guid), Guid requestId = default(Guid), string varEvent = default(string), BotEventResult? result = default(BotEventResult?), int code = default(int), DateTimeOffset datetime = default(DateTimeOffset))
        {
            this.BotId = botId;
            this.RequestId = requestId;
            // to ensure "varEvent" is required (not null)
            if (varEvent == null)
            {
                throw new ArgumentNullException("varEvent is a required property for BotEventLog and cannot be null");
            }
            this.Event = varEvent;
            this.Code = code;
            this.Datetime = datetime;
            this.Result = result;
        }

        /// <summary>
        /// BOT UUID
        /// </summary>
        /// <value>BOT UUID</value>
        [DataMember(Name = "botId", IsRequired = true, EmitDefaultValue = true)]
        public Guid BotId { get; set; }

        /// <summary>
        /// リクエストUUID
        /// </summary>
        /// <value>リクエストUUID</value>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = true)]
        public Guid RequestId { get; set; }

        /// <summary>
        /// イベントタイプ
        /// </summary>
        /// <value>イベントタイプ</value>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = true)]
        public string Event { get; set; }

        /// <summary>
        /// ステータスコード
        /// </summary>
        /// <value>ステータスコード</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public int Code { get; set; }

        /// <summary>
        /// イベント日時
        /// </summary>
        /// <value>イベント日時</value>
        [DataMember(Name = "datetime", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Datetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BotEventLog {\n");
            sb.Append("  BotId: ").Append(BotId).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
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
