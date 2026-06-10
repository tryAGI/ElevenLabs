
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemToolConfigOutputParamsDiscriminatorSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        EndProcedure,
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
        PlayKeypadTouchTone,
        /// <summary>
        /// 
        /// </summary>
        SkipTurn,
        /// <summary>
        /// 
        /// </summary>
        StartProcedure,
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
    public static class SystemToolConfigOutputParamsDiscriminatorSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigOutputParamsDiscriminatorSystemToolType value)
        {
            return value switch
            {
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall => "end_call",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndProcedure => "end_procedure",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.KnowledgeBaseRag => "knowledge_base_rag",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection => "language_detection",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone => "play_keypad_touch_tone",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn => "skip_turn",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.StartProcedure => "start_procedure",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent => "transfer_to_agent",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber => "transfer_to_number",
                SystemToolConfigOutputParamsDiscriminatorSystemToolType.VoicemailDetection => "voicemail_detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigOutputParamsDiscriminatorSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall,
                "end_procedure" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndProcedure,
                "knowledge_base_rag" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.KnowledgeBaseRag,
                "language_detection" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection,
                "play_keypad_touch_tone" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone,
                "skip_turn" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn,
                "start_procedure" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.StartProcedure,
                "transfer_to_agent" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent,
                "transfer_to_number" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber,
                "voicemail_detection" => SystemToolConfigOutputParamsDiscriminatorSystemToolType.VoicemailDetection,
                _ => null,
            };
        }
    }
}