
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_number
    /// </summary>
    public enum TransferToNumberToolConfigInputSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberToolConfigInputSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberToolConfigInputSystemToolType value)
        {
            return value switch
            {
                TransferToNumberToolConfigInputSystemToolType.TransferToNumber => "transfer_to_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberToolConfigInputSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_number" => TransferToNumberToolConfigInputSystemToolType.TransferToNumber,
                _ => null,
            };
        }
    }
}