
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReasonJsonConverter))]
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? BranchReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="branchReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator(
            global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? branchReason)
        {
            this.BranchReason = branchReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator" /> class.
        /// </summary>
        public TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator()
        {
        }

    }
}