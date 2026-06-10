
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: semantic_vad
    /// </summary>
    public enum TurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        SemanticVad,
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnDetectionType value)
        {
            return value switch
            {
                TurnDetectionType.SemanticVad => "semantic_vad",
                TurnDetectionType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "semantic_vad" => TurnDetectionType.SemanticVad,
                "server_vad" => TurnDetectionType.ServerVad,
                _ => null,
            };
        }
    }
}