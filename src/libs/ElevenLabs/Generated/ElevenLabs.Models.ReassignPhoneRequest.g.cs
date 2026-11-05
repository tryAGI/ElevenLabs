
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Body for attaching a phone number to a different receptionist.
    /// </summary>
    public sealed partial class ReassignPhoneRequest
    {
        /// <summary>
        /// The receptionist that answers calls to the number from now on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_facing_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerFacingAgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReassignPhoneRequest" /> class.
        /// </summary>
        /// <param name="customerFacingAgentId">
        /// The receptionist that answers calls to the number from now on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReassignPhoneRequest(
            string customerFacingAgentId)
        {
            this.CustomerFacingAgentId = customerFacingAgentId ?? throw new global::System.ArgumentNullException(nameof(customerFacingAgentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReassignPhoneRequest" /> class.
        /// </summary>
        public ReassignPhoneRequest()
        {
        }

    }
}