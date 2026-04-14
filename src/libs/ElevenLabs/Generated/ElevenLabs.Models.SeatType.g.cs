
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Seat types for workspace members.
    /// </summary>
    public enum SeatType
    {
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceLiteMember,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeatType value)
        {
            return value switch
            {
                SeatType.WorkspaceAdmin => "workspace_admin",
                SeatType.WorkspaceLiteMember => "workspace_lite_member",
                SeatType.WorkspaceMember => "workspace_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeatType? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => SeatType.WorkspaceAdmin,
                "workspace_lite_member" => SeatType.WorkspaceLiteMember,
                "workspace_member" => SeatType.WorkspaceMember,
                _ => null,
            };
        }
    }
}