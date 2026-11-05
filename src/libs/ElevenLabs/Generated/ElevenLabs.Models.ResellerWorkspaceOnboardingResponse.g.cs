
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResellerWorkspaceOnboardingResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_completed_at_unix")]
        public int? OnboardingCompletedAtUnix { get; set; }

        /// <summary>
        /// The receptionist onboarding created or promoted.
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
        /// Initializes a new instance of the <see cref="ResellerWorkspaceOnboardingResponse" /> class.
        /// </summary>
        /// <param name="customerFacingAgentId">
        /// The receptionist onboarding created or promoted.
        /// </param>
        /// <param name="onboardingCompletedAtUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerWorkspaceOnboardingResponse(
            string customerFacingAgentId,
            int? onboardingCompletedAtUnix)
        {
            this.OnboardingCompletedAtUnix = onboardingCompletedAtUnix;
            this.CustomerFacingAgentId = customerFacingAgentId ?? throw new global::System.ArgumentNullException(nameof(customerFacingAgentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerWorkspaceOnboardingResponse" /> class.
        /// </summary>
        public ResellerWorkspaceOnboardingResponse()
        {
        }

    }
}