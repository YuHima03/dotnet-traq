namespace DotnetTraq.Api.Models
{
    public readonly struct GetActivityTimelineRequest
    {
        public readonly bool? GetFromAllChannels { get; init; }

        public readonly bool? GetLatestOneFromEachChannel { get; init; }

        public readonly int? Limit { get; init; }
    }
}
