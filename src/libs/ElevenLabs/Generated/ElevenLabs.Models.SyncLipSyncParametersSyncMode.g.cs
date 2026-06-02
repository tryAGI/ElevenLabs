
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: cut_off
    /// </summary>
    public enum SyncLipSyncParametersSyncMode
    {
        /// <summary>
        /// 
        /// </summary>
        Bounce,
        /// <summary>
        /// 
        /// </summary>
        CutOff,
        /// <summary>
        /// 
        /// </summary>
        Loop,
        /// <summary>
        /// 
        /// </summary>
        Remap,
        /// <summary>
        /// 
        /// </summary>
        Silence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SyncLipSyncParametersSyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncLipSyncParametersSyncMode value)
        {
            return value switch
            {
                SyncLipSyncParametersSyncMode.Bounce => "bounce",
                SyncLipSyncParametersSyncMode.CutOff => "cut_off",
                SyncLipSyncParametersSyncMode.Loop => "loop",
                SyncLipSyncParametersSyncMode.Remap => "remap",
                SyncLipSyncParametersSyncMode.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncLipSyncParametersSyncMode? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => SyncLipSyncParametersSyncMode.Bounce,
                "cut_off" => SyncLipSyncParametersSyncMode.CutOff,
                "loop" => SyncLipSyncParametersSyncMode.Loop,
                "remap" => SyncLipSyncParametersSyncMode.Remap,
                "silence" => SyncLipSyncParametersSyncMode.Silence,
                _ => null,
            };
        }
    }
}