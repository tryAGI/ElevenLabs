#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Import Phone Number<br/>
        /// Import Phone Number from provider configuration (Twilio or SIP trunk)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreatePhoneNumberResponseModel> Create4Async(

            global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Phone Number<br/>
        /// Import Phone Number from provider configuration (Twilio or SIP trunk)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreatePhoneNumberResponseModel> Create4Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}