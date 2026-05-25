
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExotelApiSubdomain
    {
        /// <summary>
        /// 
        /// </summary>
        ApiExotelCom,
        /// <summary>
        /// 
        /// </summary>
        ApiInExotelCom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExotelApiSubdomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExotelApiSubdomain value)
        {
            return value switch
            {
                ExotelApiSubdomain.ApiExotelCom => "api.exotel.com",
                ExotelApiSubdomain.ApiInExotelCom => "api.in.exotel.com",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExotelApiSubdomain? ToEnum(string value)
        {
            return value switch
            {
                "api.exotel.com" => ExotelApiSubdomain.ApiExotelCom,
                "api.in.exotel.com" => ExotelApiSubdomain.ApiInExotelCom,
                _ => null,
            };
        }
    }
}