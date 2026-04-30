
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceAccessInfoAnonymousAccessLevelOverride2
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Commenter,
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
    public static class ResourceAccessInfoAnonymousAccessLevelOverride2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceAccessInfoAnonymousAccessLevelOverride2 value)
        {
            return value switch
            {
                ResourceAccessInfoAnonymousAccessLevelOverride2.Admin => "admin",
                ResourceAccessInfoAnonymousAccessLevelOverride2.Commenter => "commenter",
                ResourceAccessInfoAnonymousAccessLevelOverride2.Editor => "editor",
                ResourceAccessInfoAnonymousAccessLevelOverride2.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceAccessInfoAnonymousAccessLevelOverride2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResourceAccessInfoAnonymousAccessLevelOverride2.Admin,
                "commenter" => ResourceAccessInfoAnonymousAccessLevelOverride2.Commenter,
                "editor" => ResourceAccessInfoAnonymousAccessLevelOverride2.Editor,
                "viewer" => ResourceAccessInfoAnonymousAccessLevelOverride2.Viewer,
                _ => null,
            };
        }
    }
}