
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: cut_off
    /// </summary>
    public enum SyncLipSyncTemplateParametersSyncMode
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
    public static class SyncLipSyncTemplateParametersSyncModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncLipSyncTemplateParametersSyncMode value)
        {
            return value switch
            {
                SyncLipSyncTemplateParametersSyncMode.Bounce => "bounce",
                SyncLipSyncTemplateParametersSyncMode.CutOff => "cut_off",
                SyncLipSyncTemplateParametersSyncMode.Loop => "loop",
                SyncLipSyncTemplateParametersSyncMode.Remap => "remap",
                SyncLipSyncTemplateParametersSyncMode.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncLipSyncTemplateParametersSyncMode? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => SyncLipSyncTemplateParametersSyncMode.Bounce,
                "cut_off" => SyncLipSyncTemplateParametersSyncMode.CutOff,
                "loop" => SyncLipSyncTemplateParametersSyncMode.Loop,
                "remap" => SyncLipSyncTemplateParametersSyncMode.Remap,
                "silence" => SyncLipSyncTemplateParametersSyncMode.Silence,
                _ => null,
            };
        }
    }
}