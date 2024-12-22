namespace DotnetTraq.Extensions.Messages
{
    public enum EmbeddingType : byte
    {
        UserMention, GroupMention, Channel
    }

    public readonly ref struct TraqMessageEmbedding
    {
        public required ReadOnlySpan<char> DisplayText { get; init; }

        public required Guid EmbeddedId { get; init; }

        public required EmbeddingType Type { get; init; }

        public static int TryParseHead(ReadOnlySpan<char> text, out TraqMessageEmbedding embedding)
        {
            if (text.Length < 29 || !text.StartsWith("!{"))
            {
                embedding = default;
                return 0;
            }

            Guid? embeddedId = null;
            EmbeddingType? type = null;
            ReadOnlySpan<char> displayText = [];
            bool hasDisplayTextProperty = false;

            int cnt = 2;
            while (true)
            {
                var tmpCnt = Helpers.SpanHelper.TryParseJsonStringPropertyHead(text[cnt..], out var pn, out var val);
                switch (pn)
                {
                    case "id":
                    {
                        if (!Guid.TryParse(val, out var guid))
                        {
                            embedding = default;
                            return 0;
                        }
                        embeddedId = guid;
                        break;
                    }
                    case "type":
                    {
                        type = val switch
                        {
                            "channel" => EmbeddingType.Channel,
                            "group" => EmbeddingType.GroupMention,
                            "user" => EmbeddingType.UserMention,
                            _ => null
                        };
                        if (type is null)
                        {
                            embedding = default;
                            return 0;
                        }
                        break;
                    }
                    case "raw":
                    {
                        displayText = val;
                        hasDisplayTextProperty = true;
                        break;
                    }
                }

                cnt += tmpCnt;
                var remains = Helpers.SpanHelper.TrimStart(text[cnt..], out tmpCnt);
                cnt += tmpCnt;

                if (remains.IsEmpty)
                {
                    embedding = default;
                    return 0;
                }
                else if (remains[0] == ',')
                {
                    cnt++;
                    continue;
                }
                else if (remains[0] == '}')
                {
                    cnt++;
                    break;
                }
                else
                {
                    embedding = default;
                    return 0;
                }
            }

            if (embeddedId is null || type is null || !hasDisplayTextProperty)
            {
                embedding = default;
                return 0;
            }

            embedding = new()
            {
                DisplayText = displayText,
                EmbeddedId = embeddedId.Value,
                Type = type.Value
            };
            return cnt;
        }
    }
}
