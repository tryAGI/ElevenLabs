
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsyncConversationMetadataPlatformMetadataVariant1Discriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSourceJsonConverter))]
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? ConversationInitiationSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncConversationMetadataPlatformMetadataVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="conversationInitiationSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncConversationMetadataPlatformMetadataVariant1Discriminator(
            global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? conversationInitiationSource)
        {
            this.ConversationInitiationSource = conversationInitiationSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncConversationMetadataPlatformMetadataVariant1Discriminator" /> class.
        /// </summary>
        public AsyncConversationMetadataPlatformMetadataVariant1Discriminator()
        {
        }

    }
}