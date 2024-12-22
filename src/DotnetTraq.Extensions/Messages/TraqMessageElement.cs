namespace DotnetTraq.Extensions.Messages
{
    public enum TraqMessageElementKind : byte
    {
        NormalText = 0,
        Embedding,
        Stamp,
        Url,
    }

    public readonly ref struct TraqMessageElement(ReadOnlySpan<char> source)
    {
        readonly TraqMessageEmbedding _embedding;
        readonly TraqMessageUrl _url;

        public TraqMessageElement(ReadOnlySpan<char> source, TraqMessageEmbedding embeddingElement) : this(source)
        {
            _embedding = embeddingElement;
            Kind = TraqMessageElementKind.Embedding;
        }

        public TraqMessageElement(ReadOnlySpan<char> source, TraqMessageUrl url) : this(source)
        {
            _url = url;
            Kind = TraqMessageElementKind.Url;
        }

        public TraqMessageElementKind Kind { get; private init; } = TraqMessageElementKind.NormalText;

        public ReadOnlySpan<char> RawText { get; } = source;

        public TraqMessageEmbedding GetEmbedding()
        {
            if (Kind == TraqMessageElementKind.Embedding)
            {
                return _embedding;
            }
            throw new NotSupportedException();
        }

        public ReadOnlySpan<char> GetStampName()
        {
            if (Kind == TraqMessageElementKind.Stamp)
            {
                return RawText[1..^2];
            }
            throw new NotSupportedException();
        }

        public ReadOnlySpan<char> GetText()
        {
            if (Kind == TraqMessageElementKind.NormalText)
            {
                return RawText;
            }
            throw new NotSupportedException();
        }

        public TraqMessageUrl GetUrl()
        {
            if (Kind == TraqMessageElementKind.Url)
            {
                return _url!;
            }
            throw new NotSupportedException();
        }

        public static TraqMessageElement ParseHead(ReadOnlySpan<char> s, out int charsUsedToParse)
        {
            if (s.IsEmpty)
            {
                charsUsedToParse = 0;
                return default;
            }
            else if (char.IsWhiteSpace(s[0]))
            {
                // Extract leading string, which is filled with whitespaces.
                for (int i = 1; i < s.Length; i++)
                {
                    if (!char.IsWhiteSpace(s[i]))
                    {
                        charsUsedToParse = i;
                        return new(s[..i]);
                    }
                }
                charsUsedToParse = s.Length;
                return new(s);
            }
            else if (s.Length <= 2)
            {
                charsUsedToParse = s.Length;
                return new(s);
            }

            if (s[0] == ':') // The following text may represent a stamp.
            {
                var chr1 = s[1];
                if (char.IsLetterOrDigit(chr1) || chr1 is '-' or '_')
                {
                    for (int i = 2; i < s.Length; i++)
                    {
                        var c = s[i];
                        if (c == ':')
                        {
                            // Determined that the leading certain-length chars of `s` represent a stamp.
                            charsUsedToParse = i + 1;
                            return new(s[..(i + 1)]) { Kind = TraqMessageElementKind.Stamp };
                        }
                        else if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                int cnt;

                // Try to extract an embedded content from the head of the string.
                cnt = TraqMessageEmbedding.TryParseHead(s, out var embedding);
                if (cnt != 0)
                {
                    charsUsedToParse = cnt;
                    return new(s[..cnt], embedding);
                }

                // Try to extract a URL from the head of the string.
                cnt = TraqMessageUrl.TryParseHead(s, out var url);
                if (cnt != 0)
                {
                    charsUsedToParse = cnt;
                    return new(s[..cnt], url);
                }
            }

            // 0: ASCII letter or digit
            // 1: ASCII non-letter and non-digit
            // 2: Non-ASCII
            int prevCharKind = 0;
            bool escaping = false;

            var chr0 = s[0];
            if (char.IsAscii(chr0))
            {
                prevCharKind = char.IsAsciiLetterOrDigit(chr0) ? 0 : 1;
            }
            else
            {
                prevCharKind = 2;
            }
            escaping = chr0 == '\\';

            for (int i = 1; i < s.Length; i++)
            {
                if (escaping)
                {
                    escaping = false;
                    continue;
                }
                var c = s[i];
                if (c == '\\')
                {
                    prevCharKind = 1;
                    escaping = true;
                }
                else if (c == ':')
                {
                    charsUsedToParse = i;
                    return new(s[..i]);
                }
                else if (char.IsAscii(c))
                {
                    if (prevCharKind == 2)
                    {
                        charsUsedToParse = i;
                        return new(s[..i]);
                    }

                    if (char.IsAsciiLetterOrDigit(c))
                    {
                        if (prevCharKind == 1)
                        {
                            charsUsedToParse = i;
                            return new(s[..i]);
                        }
                        prevCharKind = 0;
                    }
                    else
                    {
                        prevCharKind = 1;
                    }
                }
                else
                {
                    prevCharKind = 2;
                }
            }
            charsUsedToParse = s.Length;
            return new(s);
        }
    }
}
