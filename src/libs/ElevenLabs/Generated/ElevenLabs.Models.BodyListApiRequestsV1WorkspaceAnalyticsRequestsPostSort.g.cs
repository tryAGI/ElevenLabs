
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort value)
        {
            return value switch
            {
                BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort.Asc => "asc",
                BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort.Asc,
                "desc" => BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort.Desc,
                _ => null,
            };
        }
    }
}