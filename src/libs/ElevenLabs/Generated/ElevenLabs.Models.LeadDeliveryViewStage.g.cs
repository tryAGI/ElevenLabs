
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The furthest the message got, or `failed` if sending it failed.
    /// </summary>
    public enum LeadDeliveryViewStage
    {
        /// <summary>
        ///
        /// </summary>
        Delivered,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Replied,
        /// <summary>
        ///
        /// </summary>
        Sent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LeadDeliveryViewStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LeadDeliveryViewStage value)
        {
            return value switch
            {
                LeadDeliveryViewStage.Delivered => "delivered",
                LeadDeliveryViewStage.Failed => "failed",
                LeadDeliveryViewStage.Queued => "queued",
                LeadDeliveryViewStage.Read => "read",
                LeadDeliveryViewStage.Replied => "replied",
                LeadDeliveryViewStage.Sent => "sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LeadDeliveryViewStage? ToEnum(string value)
        {
            return value switch
            {
                "delivered" => LeadDeliveryViewStage.Delivered,
                "failed" => LeadDeliveryViewStage.Failed,
                "queued" => LeadDeliveryViewStage.Queued,
                "read" => LeadDeliveryViewStage.Read,
                "replied" => LeadDeliveryViewStage.Replied,
                "sent" => LeadDeliveryViewStage.Sent,
                _ => null,
            };
        }
    }
}