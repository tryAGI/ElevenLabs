
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBVertical
    {
        /// <summary>
        ///
        /// </summary>
        AutoService,
        /// <summary>
        ///
        /// </summary>
        Consulting,
        /// <summary>
        ///
        /// </summary>
        Dental,
        /// <summary>
        ///
        /// </summary>
        Fitness,
        /// <summary>
        ///
        /// </summary>
        HomeServices,
        /// <summary>
        ///
        /// </summary>
        Legal,
        /// <summary>
        ///
        /// </summary>
        Medical,
        /// <summary>
        ///
        /// </summary>
        NailBeauty,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Photography,
        /// <summary>
        ///
        /// </summary>
        RealEstate,
        /// <summary>
        ///
        /// </summary>
        Restaurant,
        /// <summary>
        ///
        /// </summary>
        SalonBarbershop,
        /// <summary>
        ///
        /// </summary>
        Spa,
        /// <summary>
        ///
        /// </summary>
        Tutoring,
        /// <summary>
        ///
        /// </summary>
        Veterinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBVerticalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBVertical value)
        {
            return value switch
            {
                SMBVertical.AutoService => "auto_service",
                SMBVertical.Consulting => "consulting",
                SMBVertical.Dental => "dental",
                SMBVertical.Fitness => "fitness",
                SMBVertical.HomeServices => "home_services",
                SMBVertical.Legal => "legal",
                SMBVertical.Medical => "medical",
                SMBVertical.NailBeauty => "nail_beauty",
                SMBVertical.Other => "other",
                SMBVertical.Photography => "photography",
                SMBVertical.RealEstate => "real_estate",
                SMBVertical.Restaurant => "restaurant",
                SMBVertical.SalonBarbershop => "salon_barbershop",
                SMBVertical.Spa => "spa",
                SMBVertical.Tutoring => "tutoring",
                SMBVertical.Veterinary => "veterinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBVertical? ToEnum(string value)
        {
            return value switch
            {
                "auto_service" => SMBVertical.AutoService,
                "consulting" => SMBVertical.Consulting,
                "dental" => SMBVertical.Dental,
                "fitness" => SMBVertical.Fitness,
                "home_services" => SMBVertical.HomeServices,
                "legal" => SMBVertical.Legal,
                "medical" => SMBVertical.Medical,
                "nail_beauty" => SMBVertical.NailBeauty,
                "other" => SMBVertical.Other,
                "photography" => SMBVertical.Photography,
                "real_estate" => SMBVertical.RealEstate,
                "restaurant" => SMBVertical.Restaurant,
                "salon_barbershop" => SMBVertical.SalonBarbershop,
                "spa" => SMBVertical.Spa,
                "tutoring" => SMBVertical.Tutoring,
                "veterinary" => SMBVertical.Veterinary,
                _ => null,
            };
        }
    }
}