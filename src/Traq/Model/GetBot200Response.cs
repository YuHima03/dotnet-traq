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
using System.Reflection;

namespace Traq.Model
{
    /// <summary>
    /// GetBot200Response
    /// </summary>
    [JsonConverter(typeof(GetBot200ResponseJsonConverter))]
    [DataContract(Name = "getBot_200_response")]
    public partial class GetBot200Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBot200Response" /> class
        /// with the <see cref="Bot" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Bot.</param>
        public GetBot200Response(Bot actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBot200Response" /> class
        /// with the <see cref="BotDetail" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BotDetail.</param>
        public GetBot200Response(BotDetail actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Bot) || value is Bot)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(BotDetail) || value is BotDetail)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Bot, BotDetail");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Bot`. If the actual instance is not `Bot`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Bot</returns>
        public Bot GetBot()
        {
            return (Bot)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `BotDetail`. If the actual instance is not `BotDetail`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BotDetail</returns>
        public BotDetail GetBotDetail()
        {
            return (BotDetail)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBot200Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, GetBot200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetBot200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetBot200Response</returns>
        public static GetBot200Response FromJson(string jsonString)
        {
            GetBot200Response newGetBot200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetBot200Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Bot).GetProperty("AdditionalProperties") == null)
                {
                    newGetBot200Response = new GetBot200Response(JsonConvert.DeserializeObject<Bot>(jsonString, GetBot200Response.SerializerSettings));
                }
                else
                {
                    newGetBot200Response = new GetBot200Response(JsonConvert.DeserializeObject<Bot>(jsonString, GetBot200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Bot");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Bot: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BotDetail).GetProperty("AdditionalProperties") == null)
                {
                    newGetBot200Response = new GetBot200Response(JsonConvert.DeserializeObject<BotDetail>(jsonString, GetBot200Response.SerializerSettings));
                }
                else
                {
                    newGetBot200Response = new GetBot200Response(JsonConvert.DeserializeObject<BotDetail>(jsonString, GetBot200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("BotDetail");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BotDetail: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newGetBot200Response;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for GetBot200Response
    /// </summary>
    public class GetBot200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetBot200Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return GetBot200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return GetBot200Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
