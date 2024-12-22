using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraq.Api.Models
{
    public readonly struct SearchMessageQuery
    {
        public readonly Guid? ChannelId { get; init; }

        public readonly DateTimeOffset? Since { get; init; }

        public readonly DateTimeOffset? Until { get; init; }

        public readonly string? Word { get; init; }
    }
}
