
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalSyncType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalSyncTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalSyncType value)
        {
            return value switch
            {
                ExternalSyncType.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalSyncType? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => ExternalSyncType.GoogleDrive,
                _ => null,
            };
        }
    }
}