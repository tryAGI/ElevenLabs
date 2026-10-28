
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Answer shape for a per-item intake question.<br/>
    /// Default Value: text
    /// </summary>
    public enum IntakeQuestionKind
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntakeQuestionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntakeQuestionKind value)
        {
            return value switch
            {
                IntakeQuestionKind.Choice => "choice",
                IntakeQuestionKind.Number => "number",
                IntakeQuestionKind.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntakeQuestionKind? ToEnum(string value)
        {
            return value switch
            {
                "choice" => IntakeQuestionKind.Choice,
                "number" => IntakeQuestionKind.Number,
                "text" => IntakeQuestionKind.Text,
                _ => null,
            };
        }
    }
}