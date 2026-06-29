
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDubsDubbingModelsVariant1Item
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
    public static class ListDubsDubbingModelsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsDubbingModelsVariant1Item value)
        {
            return value switch
            {
                ListDubsDubbingModelsVariant1Item.DubbingV1 => "dubbing_v1",
                ListDubsDubbingModelsVariant1Item.DubbingV2 => "dubbing_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsDubbingModelsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "dubbing_v1" => ListDubsDubbingModelsVariant1Item.DubbingV1,
                "dubbing_v2" => ListDubsDubbingModelsVariant1Item.DubbingV2,
                _ => null,
            };
        }
    }
}