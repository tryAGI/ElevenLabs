
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePhoneAssignmentRequest(
            string customerFacingAgentId,
            global::System.Collections.Generic.IList<string>? areaCodes,
            global::ElevenLabs.ApplicationNumberType? numberType)
        {
            this.CustomerFacingAgentId = customerFacingAgentId ?? throw new global::System.ArgumentNullException(nameof(customerFacingAgentId));
            this.AreaCodes = areaCodes;
            this.NumberType = numberType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneAssignmentRequest" /> class.
        /// </summary>
        public CreatePhoneAssignmentRequest()
        {
        }

    }
}