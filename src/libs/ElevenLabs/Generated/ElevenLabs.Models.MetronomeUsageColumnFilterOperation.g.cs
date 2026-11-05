
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MetronomeUsageColumnFilterOperation
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        In,
        /// <summary>
        ///
        /// </summary>
        Neq,
        /// <summary>
        ///
        /// </summary>
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetronomeUsageColumnFilterOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetronomeUsageColumnFilterOperation value)
        {
            return value switch
            {
                MetronomeUsageColumnFilterOperation.Eq => "eq",
                MetronomeUsageColumnFilterOperation.In => "in",
                MetronomeUsageColumnFilterOperation.Neq => "neq",
                MetronomeUsageColumnFilterOperation.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetronomeUsageColumnFilterOperation? ToEnum(string value)
        {
            return value switch
            {
                "eq" => MetronomeUsageColumnFilterOperation.Eq,
                "in" => MetronomeUsageColumnFilterOperation.In,
                "neq" => MetronomeUsageColumnFilterOperation.Neq,
                "not_in" => MetronomeUsageColumnFilterOperation.NotIn,
                _ => null,
            };
        }
    }
}