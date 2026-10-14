
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TransferBranchInfoConfigured
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"configured"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_reason")]
        public string BranchReason { get; set; } = "configured";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoConfigured" /> class.
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="branchReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferBranchInfoConfigured(
            string branchId,
            string branchReason = "configured")
        {
            this.BranchReason = branchReason;
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferBranchInfoConfigured" /> class.
        /// </summary>
        public TransferBranchInfoConfigured()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TransferBranchInfoConfigured"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TransferBranchInfoConfigured FromBranchId(string branchId)
        {
            return new TransferBranchInfoConfigured
            {
                BranchId = branchId,
            };
        }

    }
}