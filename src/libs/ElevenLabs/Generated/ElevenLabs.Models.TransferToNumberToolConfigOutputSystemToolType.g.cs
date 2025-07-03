
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_number
    /// </summary>
    public enum TransferToNumberToolConfigOutputSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberToolConfigOutputSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberToolConfigOutputSystemToolType value)
        {
            return value switch
            {
                TransferToNumberToolConfigOutputSystemToolType.TransferToNumber => "transfer_to_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberToolConfigOutputSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_number" => TransferToNumberToolConfigOutputSystemToolType.TransferToNumber,
                _ => null,
            };
        }
    }
}