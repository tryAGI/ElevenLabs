
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: cancellation
    /// </summary>
    public enum PendingCancellationResponseModelKind
    {
        /// <summary>
        /// 
        /// </summary>
        Cancellation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PendingCancellationResponseModelKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingCancellationResponseModelKind value)
        {
            return value switch
            {
                PendingCancellationResponseModelKind.Cancellation => "cancellation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingCancellationResponseModelKind? ToEnum(string value)
        {
            return value switch
            {
                "cancellation" => PendingCancellationResponseModelKind.Cancellation,
                _ => null,
            };
        }
    }
}