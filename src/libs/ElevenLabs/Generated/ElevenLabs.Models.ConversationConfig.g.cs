
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfig
    {
        /// <summary>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_events")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? ClientEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfig" /> class.
        /// </summary>
        /// <param name="maxDurationSeconds">
        /// Default Value: 600
        /// </param>
        /// <param name="clientEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfig(
            int? maxDurationSeconds,
            global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? clientEvents)
        {
            this.MaxDurationSeconds = maxDurationSeconds;
            this.ClientEvents = clientEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfig" /> class.
        /// </summary>
        public ConversationConfig()
        {
        }
    }
}