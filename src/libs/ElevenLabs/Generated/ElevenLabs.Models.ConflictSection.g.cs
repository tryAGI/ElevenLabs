
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConflictSection
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationConfig,
        /// <summary>
        /// 
        /// </summary>
        PlatformSettings,
        /// <summary>
        /// 
        /// </summary>
        Procedures,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConflictSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConflictSection value)
        {
            return value switch
            {
                ConflictSection.ConversationConfig => "conversation_config",
                ConflictSection.PlatformSettings => "platform_settings",
                ConflictSection.Procedures => "procedures",
                ConflictSection.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConflictSection? ToEnum(string value)
        {
            return value switch
            {
                "conversation_config" => ConflictSection.ConversationConfig,
                "platform_settings" => ConflictSection.PlatformSettings,
                "procedures" => ConflictSection.Procedures,
                "workflow" => ConflictSection.Workflow,
                _ => null,
            };
        }
    }
}