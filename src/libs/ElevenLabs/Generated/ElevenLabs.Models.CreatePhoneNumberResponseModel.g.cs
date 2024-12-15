
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePhoneNumberResponseModel
    {
        /// <summary>
        /// Phone entity id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumberId">
        /// Phone entity id
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreatePhoneNumberResponseModel(
            string phoneNumberId)
        {
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberResponseModel" /> class.
        /// </summary>
        public CreatePhoneNumberResponseModel()
        {
        }
    }
}