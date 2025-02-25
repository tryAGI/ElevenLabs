
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum TagKind
    {
        /// <summary>
        /// 
        /// </summary>
        Lang,
        /// <summary>
        /// 
        /// </summary>
        JobType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TagKind value)
        {
            return value switch
            {
                TagKind.Lang => "lang",
                TagKind.JobType => "job_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TagKind? ToEnum(string value)
        {
            return value switch
            {
                "lang" => TagKind.Lang,
                "job_type" => TagKind.JobType,
                _ => null,
            };
        }
    }
}