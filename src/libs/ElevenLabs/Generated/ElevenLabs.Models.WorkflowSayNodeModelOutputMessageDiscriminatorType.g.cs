
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkflowSayNodeModelOutputMessageDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Literal,
        /// <summary>
        ///
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowSayNodeModelOutputMessageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowSayNodeModelOutputMessageDiscriminatorType value)
        {
            return value switch
            {
                WorkflowSayNodeModelOutputMessageDiscriminatorType.Literal => "literal",
                WorkflowSayNodeModelOutputMessageDiscriminatorType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowSayNodeModelOutputMessageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "literal" => WorkflowSayNodeModelOutputMessageDiscriminatorType.Literal,
                "prompt" => WorkflowSayNodeModelOutputMessageDiscriminatorType.Prompt,
                _ => null,
            };
        }
    }
}