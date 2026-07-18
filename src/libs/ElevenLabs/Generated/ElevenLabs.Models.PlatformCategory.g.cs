
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Buckets that make up the non-LLM ``platform_charge`` of a conversation.
    /// </summary>
    public enum PlatformCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Asr,
        /// <summary>
        /// 
        /// </summary>
        Burst,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Reception,
        /// <summary>
        /// 
        /// </summary>
        Silence,
        /// <summary>
        /// 
        /// </summary>
        TextMessage,
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformCategory value)
        {
            return value switch
            {
                PlatformCategory.Asr => "asr",
                PlatformCategory.Burst => "burst",
                PlatformCategory.Other => "other",
                PlatformCategory.Reception => "reception",
                PlatformCategory.Silence => "silence",
                PlatformCategory.TextMessage => "text_message",
                PlatformCategory.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformCategory? ToEnum(string value)
        {
            return value switch
            {
                "asr" => PlatformCategory.Asr,
                "burst" => PlatformCategory.Burst,
                "other" => PlatformCategory.Other,
                "reception" => PlatformCategory.Reception,
                "silence" => PlatformCategory.Silence,
                "text_message" => PlatformCategory.TextMessage,
                "voice" => PlatformCategory.Voice,
                _ => null,
            };
        }
    }
}