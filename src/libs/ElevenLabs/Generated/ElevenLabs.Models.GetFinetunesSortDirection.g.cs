
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Sort direction (asc or desc)<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetFinetunesSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFinetunesSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFinetunesSortDirection value)
        {
            return value switch
            {
                GetFinetunesSortDirection.Asc => "asc",
                GetFinetunesSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFinetunesSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetFinetunesSortDirection.Asc,
                "desc" => GetFinetunesSortDirection.Desc,
                _ => null,
            };
        }
    }
}