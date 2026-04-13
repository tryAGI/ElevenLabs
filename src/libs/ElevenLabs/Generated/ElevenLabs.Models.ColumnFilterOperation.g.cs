
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColumnFilterOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Ge,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Le,
        /// <summary>
        /// 
        /// </summary>
        Lt,
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
    public static class ColumnFilterOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColumnFilterOperation value)
        {
            return value switch
            {
                ColumnFilterOperation.Eq => "eq",
                ColumnFilterOperation.Ge => "ge",
                ColumnFilterOperation.Gt => "gt",
                ColumnFilterOperation.In => "in",
                ColumnFilterOperation.Le => "le",
                ColumnFilterOperation.Lt => "lt",
                ColumnFilterOperation.Neq => "neq",
                ColumnFilterOperation.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColumnFilterOperation? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ColumnFilterOperation.Eq,
                "ge" => ColumnFilterOperation.Ge,
                "gt" => ColumnFilterOperation.Gt,
                "in" => ColumnFilterOperation.In,
                "le" => ColumnFilterOperation.Le,
                "lt" => ColumnFilterOperation.Lt,
                "neq" => ColumnFilterOperation.Neq,
                "not_in" => ColumnFilterOperation.NotIn,
                _ => null,
            };
        }
    }
}