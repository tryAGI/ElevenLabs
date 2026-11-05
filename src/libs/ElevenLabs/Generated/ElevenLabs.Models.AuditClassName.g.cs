
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// OCSF event classes emitted in audit logs.
    /// </summary>
    public enum AuditClassName
    {
        /// <summary>
        ///
        /// </summary>
        AccountChange,
        /// <summary>
        ///
        /// </summary>
        Authentication,
        /// <summary>
        ///
        /// </summary>
        EntityManagement,
        /// <summary>
        ///
        /// </summary>
        GroupManagement,
        /// <summary>
        ///
        /// </summary>
        UserAccessManagement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditClassNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditClassName value)
        {
            return value switch
            {
                AuditClassName.AccountChange => "Account Change",
                AuditClassName.Authentication => "Authentication",
                AuditClassName.EntityManagement => "Entity Management",
                AuditClassName.GroupManagement => "Group Management",
                AuditClassName.UserAccessManagement => "User Access Management",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditClassName? ToEnum(string value)
        {
            return value switch
            {
                "Account Change" => AuditClassName.AccountChange,
                "Authentication" => AuditClassName.Authentication,
                "Entity Management" => AuditClassName.EntityManagement,
                "Group Management" => AuditClassName.GroupManagement,
                "User Access Management" => AuditClassName.UserAccessManagement,
                _ => null,
            };
        }
    }
}