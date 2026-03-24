
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenesysRegion
    {
        /// <summary>
        /// 
        /// </summary>
        ApNortheast1,
        /// <summary>
        /// 
        /// </summary>
        ApNortheast2,
        /// <summary>
        /// 
        /// </summary>
        ApNortheast3,
        /// <summary>
        /// 
        /// </summary>
        ApSouth1,
        /// <summary>
        /// 
        /// </summary>
        ApSoutheast1,
        /// <summary>
        /// 
        /// </summary>
        ApSoutheast2,
        /// <summary>
        /// 
        /// </summary>
        CaCentral1,
        /// <summary>
        /// 
        /// </summary>
        EuCentral1,
        /// <summary>
        /// 
        /// </summary>
        EuCentral2,
        /// <summary>
        /// 
        /// </summary>
        EuWest1,
        /// <summary>
        /// 
        /// </summary>
        EuWest2,
        /// <summary>
        /// 
        /// </summary>
        MeCentral1,
        /// <summary>
        /// 
        /// </summary>
        MxCentral1,
        /// <summary>
        /// 
        /// </summary>
        SaEast1,
        /// <summary>
        /// 
        /// </summary>
        UsEast1,
        /// <summary>
        /// 
        /// </summary>
        UsEast2,
        /// <summary>
        /// 
        /// </summary>
        UsWest2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenesysRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenesysRegion value)
        {
            return value switch
            {
                GenesysRegion.ApNortheast1 => "ap_northeast_1",
                GenesysRegion.ApNortheast2 => "ap_northeast_2",
                GenesysRegion.ApNortheast3 => "ap_northeast_3",
                GenesysRegion.ApSouth1 => "ap_south_1",
                GenesysRegion.ApSoutheast1 => "ap_southeast_1",
                GenesysRegion.ApSoutheast2 => "ap_southeast_2",
                GenesysRegion.CaCentral1 => "ca_central_1",
                GenesysRegion.EuCentral1 => "eu_central_1",
                GenesysRegion.EuCentral2 => "eu_central_2",
                GenesysRegion.EuWest1 => "eu_west_1",
                GenesysRegion.EuWest2 => "eu_west_2",
                GenesysRegion.MeCentral1 => "me_central_1",
                GenesysRegion.MxCentral1 => "mx_central_1",
                GenesysRegion.SaEast1 => "sa_east_1",
                GenesysRegion.UsEast1 => "us_east_1",
                GenesysRegion.UsEast2 => "us_east_2",
                GenesysRegion.UsWest2 => "us_west_2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenesysRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap_northeast_1" => GenesysRegion.ApNortheast1,
                "ap_northeast_2" => GenesysRegion.ApNortheast2,
                "ap_northeast_3" => GenesysRegion.ApNortheast3,
                "ap_south_1" => GenesysRegion.ApSouth1,
                "ap_southeast_1" => GenesysRegion.ApSoutheast1,
                "ap_southeast_2" => GenesysRegion.ApSoutheast2,
                "ca_central_1" => GenesysRegion.CaCentral1,
                "eu_central_1" => GenesysRegion.EuCentral1,
                "eu_central_2" => GenesysRegion.EuCentral2,
                "eu_west_1" => GenesysRegion.EuWest1,
                "eu_west_2" => GenesysRegion.EuWest2,
                "me_central_1" => GenesysRegion.MeCentral1,
                "mx_central_1" => GenesysRegion.MxCentral1,
                "sa_east_1" => GenesysRegion.SaEast1,
                "us_east_1" => GenesysRegion.UsEast1,
                "us_east_2" => GenesysRegion.UsEast2,
                "us_west_2" => GenesysRegion.UsWest2,
                _ => null,
            };
        }
    }
}