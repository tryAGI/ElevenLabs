
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource
    {
        /// <summary>
        ///
        /// </summary>
        PlainIntegration,
        /// <summary>
        ///
        /// </summary>
        ZendeskIntegration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource value)
        {
            return value switch
            {
                AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource.PlainIntegration => "plain_integration",
                AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource.ZendeskIntegration => "zendesk_integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? ToEnum(string value)
        {
            return value switch
            {
                "plain_integration" => AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource.PlainIntegration,
                "zendesk_integration" => AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource.ZendeskIntegration,
                _ => null,
            };
        }
    }
}