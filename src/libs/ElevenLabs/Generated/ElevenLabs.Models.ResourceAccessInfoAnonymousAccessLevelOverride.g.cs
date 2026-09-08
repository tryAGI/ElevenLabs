
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResourceAccessInfoAnonymousAccessLevelOverride
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
    public static class ResourceAccessInfoAnonymousAccessLevelOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceAccessInfoAnonymousAccessLevelOverride value)
        {
            return value switch
            {
                ResourceAccessInfoAnonymousAccessLevelOverride.Admin => "admin",
                ResourceAccessInfoAnonymousAccessLevelOverride.Commenter => "commenter",
                ResourceAccessInfoAnonymousAccessLevelOverride.Editor => "editor",
                ResourceAccessInfoAnonymousAccessLevelOverride.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceAccessInfoAnonymousAccessLevelOverride? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResourceAccessInfoAnonymousAccessLevelOverride.Admin,
                "commenter" => ResourceAccessInfoAnonymousAccessLevelOverride.Commenter,
                "editor" => ResourceAccessInfoAnonymousAccessLevelOverride.Editor,
                "viewer" => ResourceAccessInfoAnonymousAccessLevelOverride.Viewer,
                _ => null,
            };
        }
    }
}