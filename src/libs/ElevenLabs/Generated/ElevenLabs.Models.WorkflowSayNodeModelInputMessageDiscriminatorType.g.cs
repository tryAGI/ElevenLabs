
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkflowSayNodeModelInputMessageDiscriminatorType
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
    public static class WorkflowSayNodeModelInputMessageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowSayNodeModelInputMessageDiscriminatorType value)
        {
            return value switch
            {
                WorkflowSayNodeModelInputMessageDiscriminatorType.Literal => "literal",
                WorkflowSayNodeModelInputMessageDiscriminatorType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowSayNodeModelInputMessageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "literal" => WorkflowSayNodeModelInputMessageDiscriminatorType.Literal,
                "prompt" => WorkflowSayNodeModelInputMessageDiscriminatorType.Prompt,
                _ => null,
            };
        }
    }
}