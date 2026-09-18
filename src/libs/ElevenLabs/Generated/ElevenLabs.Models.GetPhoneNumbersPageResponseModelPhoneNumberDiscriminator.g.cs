
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProviderJsonConverter))]
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator(
            global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator" /> class.
        /// </summary>
        public GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator()
        {
        }

    }
}