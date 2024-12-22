using System.Diagnostics.CodeAnalysis;

namespace DotnetTraq.Extensions.Messages
{
    public readonly struct TraqMessageUrl
    {
        public bool HasNoScheme { get; }

        internal Uri Uri { get; }

        public TraqMessageUrl(Uri uri, bool hasNoScheme)
        {
            if (uri.Scheme is not "http" and not "https")
            {
                throw new ArgumentException("The scheme of the uri must be HTTP or HTTPS.");
            }
            HasNoScheme = hasNoScheme;
            Uri = uri;
        }

        public Uri GetUri(ReadOnlySpan<char> defaultScheme = default)
        {
            if (HasNoScheme)
            {
                UriBuilder builder = new(this.Uri)
                {
                    Scheme = defaultScheme switch
                    {
                        "" => string.Intern("http"),
                        "http" => string.Intern("http"),
                        "https" => string.Intern("https"),
                        _ => defaultScheme.ToString(),
                    }
                };
                return builder.Uri;
            }
            return this.Uri;
        }

        public static int TryParseHead(ReadOnlySpan<char> s, out TraqMessageUrl url)
        {
            if (s.StartsWith("//") || s.StartsWith("http://") || s.StartsWith("https://"))
            {
                var isSchemeless = s[0] == '/';
                int charsUsed;
                for (charsUsed = 0; charsUsed < s.Length; charsUsed++)
                {
                    if (char.IsWhiteSpace(s[charsUsed]))
                    {
                        break;
                    }
                }

                string uriString = isSchemeless ? string.Concat("http:", s[..charsUsed]) : s[..charsUsed].ToString();
                if (Uri.TryCreate(uriString, UriKind.Absolute, out var uri))
                {
                    url = new(uri, isSchemeless);
                    return charsUsed;
                }
            }
            url = default;
            return 0;
        }
    }
}
