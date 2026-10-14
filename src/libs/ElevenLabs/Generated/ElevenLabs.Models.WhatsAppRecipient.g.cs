
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A WhatsApp user by phone number and/or BSUID; the phone wins where one is needed.
    /// </summary>
    public sealed partial class WhatsAppRecipient
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bsuid")]
        public string? Bsuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppRecipient" /> class.
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="bsuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppRecipient(
            string? phone,
            string? bsuid)
        {
            this.Phone = phone;
            this.Bsuid = bsuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppRecipient" /> class.
        /// </summary>
        public WhatsAppRecipient()
        {
        }

    }
}