#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Import Phone Number<br/>
        /// Import Phone Number from Twilio configuration
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreatePhoneNumberResponseModel> CreateConvaiPhoneNumbersCreateAsync(
            global::ElevenLabs.CreatePhoneNumberRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Import Phone Number<br/>
        /// Import Phone Number from Twilio configuration
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="provider"></param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="sid">
        /// Twilio Account SID
        /// </param>
        /// <param name="token">
        /// Twilio Auth Token
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreatePhoneNumberResponseModel> CreateConvaiPhoneNumbersCreateAsync(
            string phoneNumber,
            string label,
            string sid,
            string token,
            string? xiApiKey = default,
            global::ElevenLabs.TelephonyProvider provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}