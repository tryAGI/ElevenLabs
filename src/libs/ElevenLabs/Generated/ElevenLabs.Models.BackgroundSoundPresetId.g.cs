
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Predefined background sound preset identifiers.
    /// </summary>
    public enum BackgroundSoundPresetId
    {
        /// <summary>
        /// 
        /// </summary>
        City,
        /// <summary>
        /// 
        /// </summary>
        Elevator1,
        /// <summary>
        /// 
        /// </summary>
        Elevator2,
        /// <summary>
        /// 
        /// </summary>
        Elevator3,
        /// <summary>
        /// 
        /// </summary>
        Elevator4,
        /// <summary>
        /// 
        /// </summary>
        Office1,
        /// <summary>
        /// 
        /// </summary>
        Office2,
        /// <summary>
        /// 
        /// </summary>
        Restaurant,
        /// <summary>
        /// 
        /// </summary>
        Typing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundSoundPresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundSoundPresetId value)
        {
            return value switch
            {
                BackgroundSoundPresetId.City => "city",
                BackgroundSoundPresetId.Elevator1 => "elevator1",
                BackgroundSoundPresetId.Elevator2 => "elevator2",
                BackgroundSoundPresetId.Elevator3 => "elevator3",
                BackgroundSoundPresetId.Elevator4 => "elevator4",
                BackgroundSoundPresetId.Office1 => "office1",
                BackgroundSoundPresetId.Office2 => "office2",
                BackgroundSoundPresetId.Restaurant => "restaurant",
                BackgroundSoundPresetId.Typing => "typing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundSoundPresetId? ToEnum(string value)
        {
            return value switch
            {
                "city" => BackgroundSoundPresetId.City,
                "elevator1" => BackgroundSoundPresetId.Elevator1,
                "elevator2" => BackgroundSoundPresetId.Elevator2,
                "elevator3" => BackgroundSoundPresetId.Elevator3,
                "elevator4" => BackgroundSoundPresetId.Elevator4,
                "office1" => BackgroundSoundPresetId.Office1,
                "office2" => BackgroundSoundPresetId.Office2,
                "restaurant" => BackgroundSoundPresetId.Restaurant,
                "typing" => BackgroundSoundPresetId.Typing,
                _ => null,
            };
        }
    }
}