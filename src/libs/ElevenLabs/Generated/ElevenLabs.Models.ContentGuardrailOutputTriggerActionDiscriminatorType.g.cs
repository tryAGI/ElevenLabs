
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentGuardrailOutputTriggerActionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        Retry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentGuardrailOutputTriggerActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentGuardrailOutputTriggerActionDiscriminatorType value)
        {
            return value switch
            {
                ContentGuardrailOutputTriggerActionDiscriminatorType.EndCall => "end_call",
                ContentGuardrailOutputTriggerActionDiscriminatorType.Retry => "retry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentGuardrailOutputTriggerActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => ContentGuardrailOutputTriggerActionDiscriminatorType.EndCall,
                "retry" => ContentGuardrailOutputTriggerActionDiscriminatorType.Retry,
                _ => null,
            };
        }
    }
}