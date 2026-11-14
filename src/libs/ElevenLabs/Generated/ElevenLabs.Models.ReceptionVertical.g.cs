
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ReceptionVertical
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
    public static class ReceptionVerticalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionVertical value)
        {
            return value switch
            {
                ReceptionVertical.AutoService => "auto_service",
                ReceptionVertical.Consulting => "consulting",
                ReceptionVertical.Dental => "dental",
                ReceptionVertical.Fitness => "fitness",
                ReceptionVertical.HomeServices => "home_services",
                ReceptionVertical.Legal => "legal",
                ReceptionVertical.Medical => "medical",
                ReceptionVertical.NailBeauty => "nail_beauty",
                ReceptionVertical.Other => "other",
                ReceptionVertical.Photography => "photography",
                ReceptionVertical.RealEstate => "real_estate",
                ReceptionVertical.Restaurant => "restaurant",
                ReceptionVertical.SalonBarbershop => "salon_barbershop",
                ReceptionVertical.Spa => "spa",
                ReceptionVertical.Tutoring => "tutoring",
                ReceptionVertical.Veterinary => "veterinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionVertical? ToEnum(string value)
        {
            return value switch
            {
                "auto_service" => ReceptionVertical.AutoService,
                "consulting" => ReceptionVertical.Consulting,
                "dental" => ReceptionVertical.Dental,
                "fitness" => ReceptionVertical.Fitness,
                "home_services" => ReceptionVertical.HomeServices,
                "legal" => ReceptionVertical.Legal,
                "medical" => ReceptionVertical.Medical,
                "nail_beauty" => ReceptionVertical.NailBeauty,
                "other" => ReceptionVertical.Other,
                "photography" => ReceptionVertical.Photography,
                "real_estate" => ReceptionVertical.RealEstate,
                "restaurant" => ReceptionVertical.Restaurant,
                "salon_barbershop" => ReceptionVertical.SalonBarbershop,
                "spa" => ReceptionVertical.Spa,
                "tutoring" => ReceptionVertical.Tutoring,
                "veterinary" => ReceptionVertical.Veterinary,
                _ => null,
            };
        }
    }
}