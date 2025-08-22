
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: change
    /// </summary>
    public enum PendingSubscriptionSwitchResponseModelKind
    {
        /// <summary>
        /// 
        /// </summary>
        Change,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PendingSubscriptionSwitchResponseModelKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingSubscriptionSwitchResponseModelKind value)
        {
            return value switch
            {
                PendingSubscriptionSwitchResponseModelKind.Change => "change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingSubscriptionSwitchResponseModelKind? ToEnum(string value)
        {
            return value switch
            {
                "change" => PendingSubscriptionSwitchResponseModelKind.Change,
                _ => null,
            };
        }
    }
}