
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: play_keypad_touch_tone
    /// </summary>
    public enum PlayDTMFToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        PlayKeypadTouchTone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayDTMFToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayDTMFToolConfigSystemToolType value)
        {
            return value switch
            {
                PlayDTMFToolConfigSystemToolType.PlayKeypadTouchTone => "play_keypad_touch_tone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayDTMFToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "play_keypad_touch_tone" => PlayDTMFToolConfigSystemToolType.PlayKeypadTouchTone,
                _ => null,
            };
        }
    }
}