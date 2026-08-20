
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateManualTicketRequestModel
    {
        /// <summary>
        /// What the ticket is about, e.g. a follow-up task for the agent. This is shown as the ticket title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qa_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QaComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManualTicketRequestModel" /> class.
        /// </summary>
        /// <param name="qaComment">
        /// What the ticket is about, e.g. a follow-up task for the agent. This is shown as the ticket title.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManualTicketRequestModel(
            string qaComment)
        {
            this.QaComment = qaComment ?? throw new global::System.ArgumentNullException(nameof(qaComment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManualTicketRequestModel" /> class.
        /// </summary>
        public CreateManualTicketRequestModel()
        {
        }

    }
}