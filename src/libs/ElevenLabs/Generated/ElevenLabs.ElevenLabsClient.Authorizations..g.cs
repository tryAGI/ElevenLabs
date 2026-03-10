
#nullable enable

namespace ElevenLabs
{
    public sealed partial class ElevenLabsClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsing(
 )
        {

            Authorizations.Clear();
            Authorizations.Add(new global::ElevenLabs.EndPointAuthorization
            {
                Type = "",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}