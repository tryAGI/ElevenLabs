
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The model to use for the generation.<br/>
    /// Default Value: music_v1
    /// </summary>
    public enum BodyGenerateCompositionPlanV1MusicPlanPostModelId
    {
        /// <summary>
        /// 
        /// </summary>
        MusicV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyGenerateCompositionPlanV1MusicPlanPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyGenerateCompositionPlanV1MusicPlanPostModelId value)
        {
            return value switch
            {
                BodyGenerateCompositionPlanV1MusicPlanPostModelId.MusicV1 => "music_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyGenerateCompositionPlanV1MusicPlanPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyGenerateCompositionPlanV1MusicPlanPostModelId.MusicV1,
                _ => null,
            };
        }
    }
}