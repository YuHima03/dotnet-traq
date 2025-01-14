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
    /// イベント内容
    /// </summary>
    [JsonConverter(typeof(ChannelEventDetailJsonConverter))]
    [DataContract(Name = "ChannelEvent_detail")]
    public partial class ChannelEventDetail : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="TopicChangedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TopicChangedEvent.</param>
        public ChannelEventDetail(TopicChangedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="SubscribersChangedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SubscribersChangedEvent.</param>
        public ChannelEventDetail(SubscribersChangedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="PinAddedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PinAddedEvent.</param>
        public ChannelEventDetail(PinAddedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="PinRemovedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PinRemovedEvent.</param>
        public ChannelEventDetail(PinRemovedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="NameChangedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NameChangedEvent.</param>
        public ChannelEventDetail(NameChangedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="ParentChangedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ParentChangedEvent.</param>
        public ChannelEventDetail(ParentChangedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="VisibilityChangedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VisibilityChangedEvent.</param>
        public ChannelEventDetail(VisibilityChangedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="ForcedNotificationChangedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ForcedNotificationChangedEvent.</param>
        public ChannelEventDetail(ForcedNotificationChangedEvent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEventDetail" /> class
        /// with the <see cref="ChildCreatedEvent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChildCreatedEvent.</param>
        public ChannelEventDetail(ChildCreatedEvent actualInstance)
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
                if (value.GetType() == typeof(ChildCreatedEvent) || value is ChildCreatedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ForcedNotificationChangedEvent) || value is ForcedNotificationChangedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NameChangedEvent) || value is NameChangedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ParentChangedEvent) || value is ParentChangedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PinAddedEvent) || value is PinAddedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PinRemovedEvent) || value is PinRemovedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SubscribersChangedEvent) || value is SubscribersChangedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TopicChangedEvent) || value is TopicChangedEvent)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VisibilityChangedEvent) || value is VisibilityChangedEvent)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ChildCreatedEvent, ForcedNotificationChangedEvent, NameChangedEvent, ParentChangedEvent, PinAddedEvent, PinRemovedEvent, SubscribersChangedEvent, TopicChangedEvent, VisibilityChangedEvent");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `TopicChangedEvent`. If the actual instance is not `TopicChangedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TopicChangedEvent</returns>
        public TopicChangedEvent GetTopicChangedEvent()
        {
            return (TopicChangedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SubscribersChangedEvent`. If the actual instance is not `SubscribersChangedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SubscribersChangedEvent</returns>
        public SubscribersChangedEvent GetSubscribersChangedEvent()
        {
            return (SubscribersChangedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PinAddedEvent`. If the actual instance is not `PinAddedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PinAddedEvent</returns>
        public PinAddedEvent GetPinAddedEvent()
        {
            return (PinAddedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PinRemovedEvent`. If the actual instance is not `PinRemovedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PinRemovedEvent</returns>
        public PinRemovedEvent GetPinRemovedEvent()
        {
            return (PinRemovedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NameChangedEvent`. If the actual instance is not `NameChangedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NameChangedEvent</returns>
        public NameChangedEvent GetNameChangedEvent()
        {
            return (NameChangedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ParentChangedEvent`. If the actual instance is not `ParentChangedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ParentChangedEvent</returns>
        public ParentChangedEvent GetParentChangedEvent()
        {
            return (ParentChangedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VisibilityChangedEvent`. If the actual instance is not `VisibilityChangedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VisibilityChangedEvent</returns>
        public VisibilityChangedEvent GetVisibilityChangedEvent()
        {
            return (VisibilityChangedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ForcedNotificationChangedEvent`. If the actual instance is not `ForcedNotificationChangedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ForcedNotificationChangedEvent</returns>
        public ForcedNotificationChangedEvent GetForcedNotificationChangedEvent()
        {
            return (ForcedNotificationChangedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ChildCreatedEvent`. If the actual instance is not `ChildCreatedEvent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChildCreatedEvent</returns>
        public ChildCreatedEvent GetChildCreatedEvent()
        {
            return (ChildCreatedEvent)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelEventDetail {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ChannelEventDetail.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ChannelEventDetail
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ChannelEventDetail</returns>
        public static ChannelEventDetail FromJson(string jsonString)
        {
            ChannelEventDetail newChannelEventDetail = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newChannelEventDetail;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ChildCreatedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<ChildCreatedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<ChildCreatedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChildCreatedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChildCreatedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ForcedNotificationChangedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<ForcedNotificationChangedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<ForcedNotificationChangedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ForcedNotificationChangedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ForcedNotificationChangedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NameChangedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<NameChangedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<NameChangedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NameChangedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NameChangedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ParentChangedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<ParentChangedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<ParentChangedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ParentChangedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ParentChangedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PinAddedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<PinAddedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<PinAddedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PinAddedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PinAddedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PinRemovedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<PinRemovedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<PinRemovedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PinRemovedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PinRemovedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SubscribersChangedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<SubscribersChangedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<SubscribersChangedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SubscribersChangedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SubscribersChangedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TopicChangedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<TopicChangedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<TopicChangedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TopicChangedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TopicChangedEvent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VisibilityChangedEvent).GetProperty("AdditionalProperties") == null)
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<VisibilityChangedEvent>(jsonString, ChannelEventDetail.SerializerSettings));
                }
                else
                {
                    newChannelEventDetail = new ChannelEventDetail(JsonConvert.DeserializeObject<VisibilityChangedEvent>(jsonString, ChannelEventDetail.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VisibilityChangedEvent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VisibilityChangedEvent: {1}", jsonString, exception.ToString()));
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
            return newChannelEventDetail;
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
    /// Custom JSON converter for ChannelEventDetail
    /// </summary>
    public class ChannelEventDetailJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ChannelEventDetail).GetMethod("ToJson").Invoke(value, null)));
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
                    return ChannelEventDetail.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ChannelEventDetail.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
