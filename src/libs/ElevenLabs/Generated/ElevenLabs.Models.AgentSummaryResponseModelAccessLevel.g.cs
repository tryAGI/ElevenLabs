
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSummaryResponseModelAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSummaryResponseModelAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSummaryResponseModelAccessLevel value)
        {
            return value switch
            {
                AgentSummaryResponseModelAccessLevel.Admin => "admin",
                AgentSummaryResponseModelAccessLevel.Editor => "editor",
                AgentSummaryResponseModelAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSummaryResponseModelAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => AgentSummaryResponseModelAccessLevel.Admin,
                "editor" => AgentSummaryResponseModelAccessLevel.Editor,
                "viewer" => AgentSummaryResponseModelAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}