
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UserMessageInputItemContentItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageInputItemContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageInputItemContentItemDiscriminatorType value)
        {
            return value switch
            {
                UserMessageInputItemContentItemDiscriminatorType.File => "file",
                UserMessageInputItemContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageInputItemContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => UserMessageInputItemContentItemDiscriminatorType.File,
                "text" => UserMessageInputItemContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}