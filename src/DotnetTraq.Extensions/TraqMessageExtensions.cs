using DotnetTraq.Extensions.Messages;

namespace DotnetTraq.Extensions
{
    public static class TraqMessageExtensions
    {
        public static TraqMessageElementEnumerator GetMessageElements(this Api.Models.Message message)
        {
            return new(message.Text);
        }
    }
}
