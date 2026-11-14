
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationProgress
    {
        /// <summary>
        /// Calls due to be placed that haven't started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Scheduled { get; set; }

        /// <summary>
        /// Scheduled calls by call type. Missing keys mean none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_by_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> ScheduledByType { get; set; }

        /// <summary>
        /// WhatsApp calls waiting on the contact to grant call permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awaiting_permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AwaitingPermission { get; set; }

        /// <summary>
        /// Calls under way.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InProgress { get; set; }

        /// <summary>
        /// Ended calls whose analysis the campaign is waiting on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awaiting_analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AwaitingAnalysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProgress" /> class.
        /// </summary>
        /// <param name="scheduled">
        /// Calls due to be placed that haven't started.
        /// </param>
        /// <param name="scheduledByType">
        /// Scheduled calls by call type. Missing keys mean none.
        /// </param>
        /// <param name="awaitingPermission">
        /// WhatsApp calls waiting on the contact to grant call permission.
        /// </param>
        /// <param name="inProgress">
        /// Calls under way.
        /// </param>
        /// <param name="awaitingAnalysis">
        /// Ended calls whose analysis the campaign is waiting on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationProgress(
            int scheduled,
            global::System.Collections.Generic.Dictionary<string, int> scheduledByType,
            int awaitingPermission,
            int inProgress,
            int awaitingAnalysis)
        {
            this.Scheduled = scheduled;
            this.ScheduledByType = scheduledByType ?? throw new global::System.ArgumentNullException(nameof(scheduledByType));
            this.AwaitingPermission = awaitingPermission;
            this.InProgress = inProgress;
            this.AwaitingAnalysis = awaitingAnalysis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProgress" /> class.
        /// </summary>
        public ConversationProgress()
        {
        }

    }
}