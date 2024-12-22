using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DotnetTraq.Extensions.Helpers
{
    internal static class SpanHelper
    {
        public static ReadOnlySpan<T> Concat<T>(ReadOnlySpan<T> span1, ReadOnlySpan<T> span2)
        {
            if (span1.IsEmpty)
            {
                return span2;
            }
            else if (span2.IsEmpty)
            {
                return span1;
            }
            else if (Unsafe.ByteOffset(ref MemoryMarshal.GetReference(span1), ref MemoryMarshal.GetReference(span2)) != span1.Length * Unsafe.SizeOf<char>())
            {
                throw new ArgumentException($"The given spans are not contiguous.");
            }
            return MemoryMarshal.CreateReadOnlySpan(ref MemoryMarshal.GetReference(span1), checked(span1.Length + span2.Length));
        }

        public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> s, out int charsTrimmed)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    charsTrimmed = i;
                    return s[i..];
                }
            }
            charsTrimmed = s.Length;
            return [];
        }

        public static int TryParseJsonStringPropertyHead(ReadOnlySpan<char> s, out ReadOnlySpan<char> propertyName, out ReadOnlySpan<char> value)
        {
            if (s.Length < 5)
            {
                propertyName = value = default;
                return 0;
            }

            s = s.TrimStart(out var c1);
            var c2 = TryParseJsonStringValueHead(s, out propertyName);
            if (c2 == 0)
            {
                propertyName = value = default;
                return 0;
            }

            s = s[c2..].TrimStart(out var c3);
            if (s.Length < 3 || s[0] != ':')
            {
                propertyName = value = default;
                return 0;
            }

            s = s[1..].TrimStart(out var c4);
            var c5 = TryParseJsonStringValueHead(s, out value);
            if (c5 == 0)
            {
                propertyName = value = default;
            }

            // ____ "propName" ____ : ____ "value"
            // <c1>|<---c2--->|<c3>| |<c4>|<--c5->
            return c1 + c2 + c3 + c4 + c5 + 1;
        }

        public static int TryParseJsonStringValueHead(ReadOnlySpan<char> s, out ReadOnlySpan<char> value)
        {
            if (s.Length < 2 || s[0] != '"')
            {
                value = default;
                return 0;
            }
            bool escaping = false;
            for (int i = 1; i < s.Length; i++)
            {
                var c = s[i];
                if (escaping)
                {
                    escaping = false;
                }
                else
                {
                    if (c == '\\')
                    {
                        escaping = true;
                    }
                    else if (c == '"')
                    {
                        value = s[1..i];
                        return i + 1;
                    }
                }
            }
            value = default;
            return 0;
        }
    }
}
