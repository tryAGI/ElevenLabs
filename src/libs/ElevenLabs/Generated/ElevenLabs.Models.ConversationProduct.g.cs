
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Which product surface owns this agent document.
    /// </summary>
    public enum ConversationProduct
    {
        /// <summary>
        /// 
        /// </summary>
        Agents,
        /// <summary>
        /// 
        /// </summary>
        SpeechEngine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationProduct value)
        {
            return value switch
            {
                ConversationProduct.Agents => "agents",
                ConversationProduct.SpeechEngine => "speech_engine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationProduct? ToEnum(string value)
        {
            return value switch
            {
                "agents" => ConversationProduct.Agents,
                "speech_engine" => ConversationProduct.SpeechEngine,
                _ => null,
            };
        }
    }
}