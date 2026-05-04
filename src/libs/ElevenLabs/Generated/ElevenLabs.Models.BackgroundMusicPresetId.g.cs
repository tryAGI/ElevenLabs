
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Predefined background music preset identifiers.
    /// </summary>
    public enum BackgroundMusicPresetId
    {
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
        Typing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundMusicPresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundMusicPresetId value)
        {
            return value switch
            {
                BackgroundMusicPresetId.Elevator1 => "elevator1",
                BackgroundMusicPresetId.Elevator2 => "elevator2",
                BackgroundMusicPresetId.Elevator3 => "elevator3",
                BackgroundMusicPresetId.Elevator4 => "elevator4",
                BackgroundMusicPresetId.Typing => "typing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundMusicPresetId? ToEnum(string value)
        {
            return value switch
            {
                "elevator1" => BackgroundMusicPresetId.Elevator1,
                "elevator2" => BackgroundMusicPresetId.Elevator2,
                "elevator3" => BackgroundMusicPresetId.Elevator3,
                "elevator4" => BackgroundMusicPresetId.Elevator4,
                "typing" => BackgroundMusicPresetId.Typing,
                _ => null,
            };
        }
    }
}