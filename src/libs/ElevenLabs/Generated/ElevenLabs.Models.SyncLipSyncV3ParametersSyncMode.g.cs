
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: cut_off
    /// </summary>
    public enum SyncLipSyncV3ParametersSyncMode
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
    public static class SyncLipSyncV3ParametersSyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncLipSyncV3ParametersSyncMode value)
        {
            return value switch
            {
                SyncLipSyncV3ParametersSyncMode.Bounce => "bounce",
                SyncLipSyncV3ParametersSyncMode.CutOff => "cut_off",
                SyncLipSyncV3ParametersSyncMode.Loop => "loop",
                SyncLipSyncV3ParametersSyncMode.Remap => "remap",
                SyncLipSyncV3ParametersSyncMode.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncLipSyncV3ParametersSyncMode? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => SyncLipSyncV3ParametersSyncMode.Bounce,
                "cut_off" => SyncLipSyncV3ParametersSyncMode.CutOff,
                "loop" => SyncLipSyncV3ParametersSyncMode.Loop,
                "remap" => SyncLipSyncV3ParametersSyncMode.Remap,
                "silence" => SyncLipSyncV3ParametersSyncMode.Silence,
                _ => null,
            };
        }
    }
}