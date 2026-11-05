
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Where a classic service is delivered.<br/>
    /// Default Value: business
    /// </summary>
    public enum ServiceLocationType
    {
        /// <summary>
        ///
        /// </summary>
        Business,
        /// <summary>
        ///
        /// </summary>
        Customer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceLocationType value)
        {
            return value switch
            {
                ServiceLocationType.Business => "business",
                ServiceLocationType.Customer => "customer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceLocationType? ToEnum(string value)
        {
            return value switch
            {
                "business" => ServiceLocationType.Business,
                "customer" => ServiceLocationType.Customer,
                _ => null,
            };
        }
    }
}