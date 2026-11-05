
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum OrderFulfillmentType
    {
        /// <summary>
        ///
        /// </summary>
        Delivery,
        /// <summary>
        ///
        /// </summary>
        Digital,
        /// <summary>
        ///
        /// </summary>
        Pickup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderFulfillmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderFulfillmentType value)
        {
            return value switch
            {
                OrderFulfillmentType.Delivery => "delivery",
                OrderFulfillmentType.Digital => "digital",
                OrderFulfillmentType.Pickup => "pickup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderFulfillmentType? ToEnum(string value)
        {
            return value switch
            {
                "delivery" => OrderFulfillmentType.Delivery,
                "digital" => OrderFulfillmentType.Digital,
                "pickup" => OrderFulfillmentType.Pickup,
                _ => null,
            };
        }
    }
}