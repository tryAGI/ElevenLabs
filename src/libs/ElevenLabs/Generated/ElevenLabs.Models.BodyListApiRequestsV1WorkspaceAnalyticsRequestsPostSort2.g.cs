
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2
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
    public static class BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2 value)
        {
            return value switch
            {
                BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2.Asc => "asc",
                BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2.Asc,
                "desc" => BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2.Desc,
                _ => null,
            };
        }
    }
}