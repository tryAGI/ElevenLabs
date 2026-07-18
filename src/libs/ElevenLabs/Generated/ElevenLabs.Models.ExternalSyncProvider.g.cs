
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalSyncProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalSyncProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalSyncProvider value)
        {
            return value switch
            {
                ExternalSyncProvider.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalSyncProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => ExternalSyncProvider.GoogleDrive,
                _ => null,
            };
        }
    }
}