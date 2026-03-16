
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependentAvailableMCPServerIdentifierAccessLevel
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
        Commenter,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentAvailableMCPServerIdentifierAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableMCPServerIdentifierAccessLevel value)
        {
            return value switch
            {
                DependentAvailableMCPServerIdentifierAccessLevel.Admin => "admin",
                DependentAvailableMCPServerIdentifierAccessLevel.Editor => "editor",
                DependentAvailableMCPServerIdentifierAccessLevel.Commenter => "commenter",
                DependentAvailableMCPServerIdentifierAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableMCPServerIdentifierAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DependentAvailableMCPServerIdentifierAccessLevel.Admin,
                "editor" => DependentAvailableMCPServerIdentifierAccessLevel.Editor,
                "commenter" => DependentAvailableMCPServerIdentifierAccessLevel.Commenter,
                "viewer" => DependentAvailableMCPServerIdentifierAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}