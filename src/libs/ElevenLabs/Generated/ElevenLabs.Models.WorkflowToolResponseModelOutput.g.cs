
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A common model for workflow tool responses.
    /// </summary>
    public sealed partial class WorkflowToolResponseModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_transfer")]
        public global::ElevenLabs.TransferToAgentToolResultSuccessModel? FinalTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolResponseModelOutput" /> class.
        /// </summary>
        /// <param name="finalTransfer"></param>
        /// <param name="steps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolResponseModelOutput(
            global::ElevenLabs.TransferToAgentToolResultSuccessModel? finalTransfer,
            global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? steps)
        {
            this.FinalTransfer = finalTransfer;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolResponseModelOutput" /> class.
        /// </summary>
        public WorkflowToolResponseModelOutput()
        {
        }
    }
}