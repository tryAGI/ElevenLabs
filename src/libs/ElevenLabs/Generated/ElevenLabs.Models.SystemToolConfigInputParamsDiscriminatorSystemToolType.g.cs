
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemToolConfigInputParamsDiscriminatorSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBaseRag,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetection,
        /// <summary>
        /// 
        /// </summary>
        LoadProcedure,
        /// <summary>
        /// 
        /// </summary>
        PlayKeypadTouchTone,
        /// <summary>
        /// 
        /// </summary>
        SkipTurn,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgent,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumber,
        /// <summary>
        /// 
        /// </summary>
        VoicemailDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigInputParamsDiscriminatorSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigInputParamsDiscriminatorSystemToolType value)
        {
            return value switch
            {
                SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall => "end_call",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.KnowledgeBaseRag => "knowledge_base_rag",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection => "language_detection",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.LoadProcedure => "load_procedure",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone => "play_keypad_touch_tone",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn => "skip_turn",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent => "transfer_to_agent",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber => "transfer_to_number",
                SystemToolConfigInputParamsDiscriminatorSystemToolType.VoicemailDetection => "voicemail_detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigInputParamsDiscriminatorSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => SystemToolConfigInputParamsDiscriminatorSystemToolType.EndCall,
                "knowledge_base_rag" => SystemToolConfigInputParamsDiscriminatorSystemToolType.KnowledgeBaseRag,
                "language_detection" => SystemToolConfigInputParamsDiscriminatorSystemToolType.LanguageDetection,
                "load_procedure" => SystemToolConfigInputParamsDiscriminatorSystemToolType.LoadProcedure,
                "play_keypad_touch_tone" => SystemToolConfigInputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone,
                "skip_turn" => SystemToolConfigInputParamsDiscriminatorSystemToolType.SkipTurn,
                "transfer_to_agent" => SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToAgent,
                "transfer_to_number" => SystemToolConfigInputParamsDiscriminatorSystemToolType.TransferToNumber,
                "voicemail_detection" => SystemToolConfigInputParamsDiscriminatorSystemToolType.VoicemailDetection,
                _ => null,
            };
        }
    }
}