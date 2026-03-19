
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentGuardrailInputTriggerActionDiscriminatorType
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
    public static class ContentGuardrailInputTriggerActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentGuardrailInputTriggerActionDiscriminatorType value)
        {
            return value switch
            {
                ContentGuardrailInputTriggerActionDiscriminatorType.EndCall => "end_call",
                ContentGuardrailInputTriggerActionDiscriminatorType.Retry => "retry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentGuardrailInputTriggerActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => ContentGuardrailInputTriggerActionDiscriminatorType.EndCall,
                "retry" => ContentGuardrailInputTriggerActionDiscriminatorType.Retry,
                _ => null,
            };
        }
    }
}