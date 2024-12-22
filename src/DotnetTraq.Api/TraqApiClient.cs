using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using DotnetTraq.Api.Models;

namespace DotnetTraq.Api
{
    public sealed class TraqApiClient : IDisposable
    {
        readonly HttpClient _client;

        public Uri BaseAddress => _client.BaseAddress!;

        public TraqApiClient(HttpClient client)
        {
            _client = client;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }

        #region Activity API

        public async ValueTask<TimelineMessage[]> GetActivityTimelineAsync(GetActivityTimelineRequest request, CancellationToken ct)
        {
            DefaultInterpolatedStringHandler queryHandler = new(0, 3);
            if (request.Limit.HasValue)
            {
                queryHandler.AppendLiteral("&limit=");
                queryHandler.AppendFormatted(request.Limit.Value);
            }
            if (request.GetFromAllChannels.HasValue)
            {
                queryHandler.AppendLiteral("&all=");
                queryHandler.AppendFormatted(request.GetFromAllChannels.Value.ToString().ToLowerInvariant());
            }
            if (request.GetLatestOneFromEachChannel.HasValue)
            {
                queryHandler.AppendLiteral("&per_channel=");
                queryHandler.AppendFormatted(request.GetLatestOneFromEachChannel.Value.ToString().ToLowerInvariant());
            }

            var queryString = queryHandler.ToStringAndClear();
            var uri = string.IsNullOrEmpty(queryString) ? "/api/v3/activity/timeline" : string.Concat("/api/v3/activity/timeline?", queryString.AsSpan(1));

            var messages = await _client.GetFromJsonAsync<TimelineMessage[]>(uri, ct);
            return messages ?? [];
        }

        #endregion

        #region Channels API

        public async ValueTask<GetChannelFromPathResult> GetChannelAsync(string path, CancellationToken ct)
        {
            return (await _client.GetFromJsonAsync<GetChannelFromPathResult>($"/api/v3/channels?path={Uri.EscapeDataString(path)}", ct))!;
        }

        #endregion

        #region Messages API

        public async ValueTask<Message> GetMessageAsync(Guid id, CancellationToken ct)
        {
            return (await _client.GetFromJsonAsync<Message>($"/api/v3/messages/{id}", ct))!;
        }

        public async ValueTask<Message> PostMessageAsync(Guid channelId, PostMessageRequest req, CancellationToken ct)
        {
            StringContent requestContent = new(JsonSerializer.Serialize(req), Encoding.UTF8, "application/json");
            var result = await _client.PostAsync($"/api/v3/channels/{channelId}/messages", requestContent, ct);
            return (await result.Content.ReadFromJsonAsync<Message>(ct))!;
        }

        public async ValueTask<Message[]> SearchMessagesAsync(SearchMessageQuery query, CancellationToken ct)
        {
            DefaultInterpolatedStringHandler queryHandler = new(0, 5);
            if (query.ChannelId is not null)
            {
                queryHandler.AppendLiteral("&in=");
                queryHandler.AppendFormatted(query.ChannelId);
            }
            if (query.Since is not null)
            {
                queryHandler.AppendLiteral("&after=");
                queryHandler.AppendFormatted(Uri.EscapeDataString(query.Since.Value.ToString("O")));
            }
            if (query.Until is not null)
            {
                queryHandler.AppendLiteral("&before=");
                queryHandler.AppendFormatted(Uri.EscapeDataString(query.Until.Value.ToString("O")));
            }
            if (query.Word is not null)
            {
                queryHandler.AppendLiteral("&word=");
                queryHandler.AppendFormatted(Uri.EscapeDataString(query.Word));
            }

            var queryString = queryHandler.ToStringAndClear();
            var uri = string.IsNullOrEmpty(queryString) ? "/api/v3/messages" : string.Concat("/api/v3/messages?", queryString.AsSpan(1));

            var messages = await _client.GetFromJsonAsync<SearchMessagesResult>(uri, ct);
            return messages?.Messages ?? [];
        }

        #endregion

        #region Users API

        public async ValueTask<UserDetail> GetUserAsync(Guid id, CancellationToken ct)
        {
            return (await _client.GetFromJsonAsync<UserDetail>($"/api/v3/users/{id}", ct))!;
        }

        #endregion
    }
}
