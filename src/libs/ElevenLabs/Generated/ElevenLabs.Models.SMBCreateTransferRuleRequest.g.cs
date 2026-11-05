
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating a new transfer rule.
    /// </summary>
    public sealed partial class SMBCreateTransferRuleRequest
    {
        /// <summary>
        /// Name of the transfer destination, e.g. 'Alvin' or 'Billing team'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Number to transfer to. Without a country code it is dialed locally in the business's country, so include the country code for a number abroad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// What the caller does that triggers the transfer, e.g. 'The caller asks to speak to a human or to Alvin'. Describe only the trigger; do not restate the phone number or the word 'transfer'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// DTMF digits automatically played after the transfer destination picks up (e.g. '1' to answer a 'press 1 to accept' screen, or 'www1234' to key an extension after a pause). Valid characters are 0-9, *, #, w (0.5s pause) and W (1s pause). Twilio transfers only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits")]
        public string? PostDialDigits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBCreateTransferRuleRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// Name of the transfer destination, e.g. 'Alvin' or 'Billing team'.
        /// </param>
        /// <param name="phoneNumber">
        /// Number to transfer to. Without a country code it is dialed locally in the business's country, so include the country code for a number abroad.
        /// </param>
        /// <param name="condition">
        /// What the caller does that triggers the transfer, e.g. 'The caller asks to speak to a human or to Alvin'. Describe only the trigger; do not restate the phone number or the word 'transfer'.
        /// </param>
        /// <param name="postDialDigits">
        /// DTMF digits automatically played after the transfer destination picks up (e.g. '1' to answer a 'press 1 to accept' screen, or 'www1234' to key an extension after a pause). Valid characters are 0-9, *, #, w (0.5s pause) and W (1s pause). Twilio transfers only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBCreateTransferRuleRequest(
            string label,
            string phoneNumber,
            string condition,
            string? postDialDigits)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.PostDialDigits = postDialDigits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBCreateTransferRuleRequest" /> class.
        /// </summary>
        public SMBCreateTransferRuleRequest()
        {
        }

    }
}