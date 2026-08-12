
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the model uses the image: `subject` places its subject or scene elements into the video; `style` transfers its visual style.
    /// </summary>
    public enum VeoImageReferenceRole
    {
        /// <summary>
        /// `subject` places its subject or scene elements into the video; `style` transfers its visual style.
        /// </summary>
        Style,
        /// <summary>
        /// `subject` places its subject or scene elements into the video; `style` transfers its visual style.
        /// </summary>
        Subject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VeoImageReferenceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VeoImageReferenceRole value)
        {
            return value switch
            {
                VeoImageReferenceRole.Style => "style",
                VeoImageReferenceRole.Subject => "subject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VeoImageReferenceRole? ToEnum(string value)
        {
            return value switch
            {
                "style" => VeoImageReferenceRole.Style,
                "subject" => VeoImageReferenceRole.Subject,
                _ => null,
            };
        }
    }
}