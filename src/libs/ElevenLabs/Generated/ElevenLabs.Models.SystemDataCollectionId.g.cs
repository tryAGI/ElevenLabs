
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SystemDataCollectionId
    {
        /// <summary>
        ///
        /// </summary>
        SystemDataCollectionTopic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemDataCollectionIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemDataCollectionId value)
        {
            return value switch
            {
                SystemDataCollectionId.SystemDataCollectionTopic => "__system_data_collection_topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemDataCollectionId? ToEnum(string value)
        {
            return value switch
            {
                "__system_data_collection_topic" => SystemDataCollectionId.SystemDataCollectionTopic,
                _ => null,
            };
        }
    }
}