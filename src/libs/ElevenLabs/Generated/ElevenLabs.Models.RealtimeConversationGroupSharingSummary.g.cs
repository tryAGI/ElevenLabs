
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How widely a group is shared, besides its owner and workspace admins (who always have access).
    /// </summary>
    public sealed partial class RealtimeConversationGroupSharingSummary
    {
        /// <summary>
        /// Distinct people besides the owner with access, whether shared directly or through a workspace group they belong to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("people_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeopleCount { get; set; }

        /// <summary>
        /// Whether every workspace member has access to the group.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_with_everyone")]
        public bool? SharedWithEveryone { get; set; }

        /// <summary>
        /// The preset role every workspace member has, when shared with everyone. None for a workspace custom role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("everyone_role")]
        public global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? EveryoneRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationGroupSharingSummary" /> class.
        /// </summary>
        /// <param name="peopleCount">
        /// Distinct people besides the owner with access, whether shared directly or through a workspace group they belong to.
        /// </param>
        /// <param name="sharedWithEveryone">
        /// Whether every workspace member has access to the group.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="everyoneRole">
        /// The preset role every workspace member has, when shared with everyone. None for a workspace custom role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationGroupSharingSummary(
            int peopleCount,
            bool? sharedWithEveryone,
            global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? everyoneRole)
        {
            this.PeopleCount = peopleCount;
            this.SharedWithEveryone = sharedWithEveryone;
            this.EveryoneRole = everyoneRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationGroupSharingSummary" /> class.
        /// </summary>
        public RealtimeConversationGroupSharingSummary()
        {
        }

    }
}