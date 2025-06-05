
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Sound effect category used for filtering.<br/>
    /// Example: Nature
    /// </summary>
    public enum GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Restaurant,
        /// <summary>
        /// 
        /// </summary>
        Park,
        /// <summary>
        /// 
        /// </summary>
        Industrial,
        /// <summary>
        /// 
        /// </summary>
        School,
        /// <summary>
        /// 
        /// </summary>
        Office,
        /// <summary>
        /// 
        /// </summary>
        Urban,
        /// <summary>
        /// 
        /// </summary>
        Ocean,
        /// <summary>
        /// 
        /// </summary>
        Nature,
        /// <summary>
        /// 
        /// </summary>
        Weather,
        /// <summary>
        /// 
        /// </summary>
        Foley,
        /// <summary>
        /// 
        /// </summary>
        Fantasy,
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        Device,
        /// <summary>
        /// 
        /// </summary>
        SciFi,
        /// <summary>
        /// 
        /// </summary>
        Horror,
        /// <summary>
        /// 
        /// </summary>
        Animal,
        /// <summary>
        /// 
        /// </summary>
        Boom,
        /// <summary>
        /// 
        /// </summary>
        Braam,
        /// <summary>
        /// 
        /// </summary>
        Riser,
        /// <summary>
        /// 
        /// </summary>
        Whoosh,
        /// <summary>
        /// 
        /// </summary>
        Drone,
        /// <summary>
        /// 
        /// </summary>
        Impact,
        /// <summary>
        /// 
        /// </summary>
        Weapon,
        /// <summary>
        /// 
        /// </summary>
        Transport,
        /// <summary>
        /// 
        /// </summary>
        Household,
        /// <summary>
        /// 
        /// </summary>
        Percussion,
        /// <summary>
        /// 
        /// </summary>
        Cymbal,
        /// <summary>
        /// 
        /// </summary>
        Synth,
        /// <summary>
        /// 
        /// </summary>
        Bass,
        /// <summary>
        /// 
        /// </summary>
        Guitar,
        /// <summary>
        /// 
        /// </summary>
        Key,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Brass,
        /// <summary>
        /// 
        /// </summary>
        Woodwind,
        /// <summary>
        /// 
        /// </summary>
        UiElement,
        /// <summary>
        /// 
        /// </summary>
        Sport,
        /// <summary>
        /// 
        /// </summary>
        Vehicle,
        /// <summary>
        /// 
        /// </summary>
        Misc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSharedSoundEffectsV1SharedSoundGenerationsGetCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory value)
        {
            return value switch
            {
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Restaurant => "restaurant",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Park => "park",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Industrial => "industrial",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.School => "school",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Office => "office",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Urban => "urban",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Ocean => "ocean",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Nature => "nature",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Weather => "weather",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Foley => "foley",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Fantasy => "fantasy",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Human => "human",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Device => "device",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.SciFi => "sci-fi",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Horror => "horror",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Animal => "animal",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Boom => "boom",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Braam => "braam",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Riser => "riser",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Whoosh => "whoosh",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Drone => "drone",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Impact => "impact",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Weapon => "weapon",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Transport => "transport",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Household => "household",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Percussion => "percussion",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Cymbal => "cymbal",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Synth => "synth",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Bass => "bass",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Guitar => "guitar",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Key => "key",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.String => "string",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Brass => "brass",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Woodwind => "woodwind",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.UiElement => "ui element",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Sport => "sport",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Vehicle => "vehicle",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Misc => "misc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory? ToEnum(string value)
        {
            return value switch
            {
                "restaurant" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Restaurant,
                "park" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Park,
                "industrial" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Industrial,
                "school" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.School,
                "office" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Office,
                "urban" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Urban,
                "ocean" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Ocean,
                "nature" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Nature,
                "weather" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Weather,
                "foley" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Foley,
                "fantasy" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Fantasy,
                "human" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Human,
                "device" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Device,
                "sci-fi" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.SciFi,
                "horror" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Horror,
                "animal" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Animal,
                "boom" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Boom,
                "braam" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Braam,
                "riser" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Riser,
                "whoosh" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Whoosh,
                "drone" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Drone,
                "impact" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Impact,
                "weapon" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Weapon,
                "transport" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Transport,
                "household" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Household,
                "percussion" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Percussion,
                "cymbal" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Cymbal,
                "synth" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Synth,
                "bass" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Bass,
                "guitar" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Guitar,
                "key" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Key,
                "string" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.String,
                "brass" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Brass,
                "woodwind" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Woodwind,
                "ui element" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.UiElement,
                "sport" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Sport,
                "vehicle" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Vehicle,
                "misc" => GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory.Misc,
                _ => null,
            };
        }
    }
}