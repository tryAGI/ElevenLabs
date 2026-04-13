
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceAnalyticsQueryResponseModelColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        DateTime,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Map,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceAnalyticsQueryResponseModelColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceAnalyticsQueryResponseModelColumnType value)
        {
            return value switch
            {
                WorkspaceAnalyticsQueryResponseModelColumnType.Bool => "Bool",
                WorkspaceAnalyticsQueryResponseModelColumnType.DateTime => "DateTime",
                WorkspaceAnalyticsQueryResponseModelColumnType.Float => "Float",
                WorkspaceAnalyticsQueryResponseModelColumnType.Int => "Int",
                WorkspaceAnalyticsQueryResponseModelColumnType.Json => "JSON",
                WorkspaceAnalyticsQueryResponseModelColumnType.Map => "Map",
                WorkspaceAnalyticsQueryResponseModelColumnType.String => "String",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceAnalyticsQueryResponseModelColumnType? ToEnum(string value)
        {
            return value switch
            {
                "Bool" => WorkspaceAnalyticsQueryResponseModelColumnType.Bool,
                "DateTime" => WorkspaceAnalyticsQueryResponseModelColumnType.DateTime,
                "Float" => WorkspaceAnalyticsQueryResponseModelColumnType.Float,
                "Int" => WorkspaceAnalyticsQueryResponseModelColumnType.Int,
                "JSON" => WorkspaceAnalyticsQueryResponseModelColumnType.Json,
                "Map" => WorkspaceAnalyticsQueryResponseModelColumnType.Map,
                "String" => WorkspaceAnalyticsQueryResponseModelColumnType.String,
                _ => null,
            };
        }
    }
}