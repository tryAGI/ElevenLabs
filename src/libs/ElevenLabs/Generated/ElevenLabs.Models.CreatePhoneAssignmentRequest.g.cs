
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Body for giving a receptionist a phone number.
    /// </summary>
    public sealed partial class CreatePhoneAssignmentRequest
    {
        /// <summary>
        /// The receptionist that answers calls to the number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_facing_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerFacingAgentId { get; set; }

        /// <summary>
        /// Preferred US or Canadian area codes, e.g. `["415", "628"]`. Codes outside the business's country are ignored, and any number is given when none of these is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("area_codes")]
        public global::System.Collections.Generic.IList<string>? AreaCodes { get; set; }

        /// <summary>
        /// Local or mobile, in a country that requires paperwork before a number takes calls. Leave unset to try mobile first. Ignored in the US and Canada.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_type")]
        public global::ElevenLabs.ApplicationNumberType? NumberType { get; set; }

        /// <summary>
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneAssignmentRequest" /> class.
        /// </summary>
        /// <param name="customerFacingAgentId">
        /// The receptionist that answers calls to the number.
        /// </param>
        /// <param name="areaCodes">
        /// Preferred US or Canadian area codes, e.g. `["415", "628"]`. Codes outside the business's country are ignored, and any number is given when none of these is available.
        /// </param>
        /// <param name="numberType">
        /// Local or mobile, in a country that requires paperwork before a number takes calls. Leave unset to try mobile first. Ignored in the US and Canada.
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePhoneAssignmentRequest(
            string customerFacingAgentId,
            global::System.Collections.Generic.IList<string>? areaCodes,
            global::ElevenLabs.ApplicationNumberType? numberType,
            string? idempotencyKey)
        {
            this.CustomerFacingAgentId = customerFacingAgentId ?? throw new global::System.ArgumentNullException(nameof(customerFacingAgentId));
            this.AreaCodes = areaCodes;
            this.NumberType = numberType;
            this.IdempotencyKey = idempotencyKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneAssignmentRequest" /> class.
        /// </summary>
        public CreatePhoneAssignmentRequest()
        {
        }

    }
}