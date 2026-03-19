
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomGuardrailConfigTriggerActionDiscriminatorType
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
    public static class CustomGuardrailConfigTriggerActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomGuardrailConfigTriggerActionDiscriminatorType value)
        {
            return value switch
            {
                CustomGuardrailConfigTriggerActionDiscriminatorType.EndCall => "end_call",
                CustomGuardrailConfigTriggerActionDiscriminatorType.Retry => "retry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomGuardrailConfigTriggerActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => CustomGuardrailConfigTriggerActionDiscriminatorType.EndCall,
                "retry" => CustomGuardrailConfigTriggerActionDiscriminatorType.Retry,
                _ => null,
            };
        }
    }
}