
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColumnUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Credits,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        Eur,
        /// <summary>
        /// 
        /// </summary>
        Inr,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Rating,
        /// <summary>
        /// 
        /// </summary>
        Ratio,
        /// <summary>
        /// 
        /// </summary>
        S,
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColumnUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColumnUnit value)
        {
            return value switch
            {
                ColumnUnit.Credits => "credits",
                ColumnUnit.Duration => "duration",
                ColumnUnit.Eur => "eur",
                ColumnUnit.Inr => "inr",
                ColumnUnit.Min => "min",
                ColumnUnit.Ms => "ms",
                ColumnUnit.Rating => "rating",
                ColumnUnit.Ratio => "ratio",
                ColumnUnit.S => "s",
                ColumnUnit.Usd => "usd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColumnUnit? ToEnum(string value)
        {
            return value switch
            {
                "credits" => ColumnUnit.Credits,
                "duration" => ColumnUnit.Duration,
                "eur" => ColumnUnit.Eur,
                "inr" => ColumnUnit.Inr,
                "min" => ColumnUnit.Min,
                "ms" => ColumnUnit.Ms,
                "rating" => ColumnUnit.Rating,
                "ratio" => ColumnUnit.Ratio,
                "s" => ColumnUnit.S,
                "usd" => ColumnUnit.Usd,
                _ => null,
            };
        }
    }
}