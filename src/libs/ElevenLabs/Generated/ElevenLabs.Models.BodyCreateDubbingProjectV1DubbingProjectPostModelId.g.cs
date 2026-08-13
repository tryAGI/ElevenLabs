
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreateDubbingProjectV1DubbingProjectPostModelId
    {
        /// <summary>
        /// 
        /// </summary>
        DubbingV1,
        /// <summary>
        /// 
        /// </summary>
        DubbingV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateDubbingProjectV1DubbingProjectPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateDubbingProjectV1DubbingProjectPostModelId value)
        {
            return value switch
            {
                BodyCreateDubbingProjectV1DubbingProjectPostModelId.DubbingV1 => "dubbing_v1",
                BodyCreateDubbingProjectV1DubbingProjectPostModelId.DubbingV2 => "dubbing_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateDubbingProjectV1DubbingProjectPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "dubbing_v1" => BodyCreateDubbingProjectV1DubbingProjectPostModelId.DubbingV1,
                "dubbing_v2" => BodyCreateDubbingProjectV1DubbingProjectPostModelId.DubbingV2,
                _ => null,
            };
        }
    }
}