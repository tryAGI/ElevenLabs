
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalysisItemAttachmentAction
    {
        /// <summary>
        ///
        /// </summary>
        Attach,
        /// <summary>
        ///
        /// </summary>
        Detach,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisItemAttachmentActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisItemAttachmentAction value)
        {
            return value switch
            {
                AnalysisItemAttachmentAction.Attach => "attach",
                AnalysisItemAttachmentAction.Detach => "detach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisItemAttachmentAction? ToEnum(string value)
        {
            return value switch
            {
                "attach" => AnalysisItemAttachmentAction.Attach,
                "detach" => AnalysisItemAttachmentAction.Detach,
                _ => null,
            };
        }
    }
}