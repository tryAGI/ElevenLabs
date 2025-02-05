
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastConversationMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PodcastConversationModeTypeJsonConverter))]
        public global::ElevenLabs.PodcastConversationModeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.PodcastConversationModeData Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationMode" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="conversation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PodcastConversationMode(
            global::ElevenLabs.PodcastConversationModeData conversation,
            global::ElevenLabs.PodcastConversationModeType type)
        {
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationMode" /> class.
        /// </summary>
        public PodcastConversationMode()
        {
        }
    }
}