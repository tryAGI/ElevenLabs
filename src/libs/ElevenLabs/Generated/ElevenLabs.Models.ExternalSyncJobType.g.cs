
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalSyncJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Incremental,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalSyncJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalSyncJobType value)
        {
            return value switch
            {
                ExternalSyncJobType.Full => "full",
                ExternalSyncJobType.Incremental => "incremental",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalSyncJobType? ToEnum(string value)
        {
            return value switch
            {
                "full" => ExternalSyncJobType.Full,
                "incremental" => ExternalSyncJobType.Incremental,
                _ => null,
            };
        }
    }
}