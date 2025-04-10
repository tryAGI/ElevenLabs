
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemToolConfigInputParamsDiscriminatorSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetection,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigInputParamsDiscriminatorSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigInputParamsDiscriminatorSystemToolType value)
        {
            return value switch
            {
                SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall => "end_call",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection => "language_detection",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent => "transfer_to_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigInputParamsDiscriminatorSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall,
                "language_detection" => SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection,
                "transfer_to_agent" => SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent,
                _ => null,
            };
        }
    }
}