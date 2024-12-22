using System.Text.Json.Serialization;

namespace DotnetTraq.Api.Models
{
    public sealed class Channel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("parentId")]
        public Guid ParentId { get; set; }
    }
}
