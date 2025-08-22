
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceApiKeyResponseModelPermission
    {
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        SpeechToText,
        /// <summary>
        /// 
        /// </summary>
        ModelsRead,
        /// <summary>
        /// 
        /// </summary>
        ModelsWrite,
        /// <summary>
        /// 
        /// </summary>
        VoicesRead,
        /// <summary>
        /// 
        /// </summary>
        VoicesWrite,
        /// <summary>
        /// 
        /// </summary>
        SpeechHistoryRead,
        /// <summary>
        /// 
        /// </summary>
        SpeechHistoryWrite,
        /// <summary>
        /// 
        /// </summary>
        SoundGeneration,
        /// <summary>
        /// 
        /// </summary>
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        VoiceGeneration,
        /// <summary>
        /// 
        /// </summary>
        DubbingRead,
        /// <summary>
        /// 
        /// </summary>
        DubbingWrite,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionariesRead,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionariesWrite,
        /// <summary>
        /// 
        /// </summary>
        UserRead,
        /// <summary>
        /// 
        /// </summary>
        UserWrite,
        /// <summary>
        /// 
        /// </summary>
        ProjectsRead,
        /// <summary>
        /// 
        /// </summary>
        ProjectsWrite,
        /// <summary>
        /// 
        /// </summary>
        AudioNativeRead,
        /// <summary>
        /// 
        /// </summary>
        AudioNativeWrite,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceRead,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceWrite,
        /// <summary>
        /// 
        /// </summary>
        ForcedAlignment,
        /// <summary>
        /// 
        /// </summary>
        ConvaiRead,
        /// <summary>
        /// 
        /// </summary>
        ConvaiWrite,
        /// <summary>
        /// 
        /// </summary>
        MusicGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceApiKeyResponseModelPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceApiKeyResponseModelPermission value)
        {
            return value switch
            {
                WorkspaceApiKeyResponseModelPermission.TextToSpeech => "text_to_speech",
                WorkspaceApiKeyResponseModelPermission.SpeechToSpeech => "speech_to_speech",
                WorkspaceApiKeyResponseModelPermission.SpeechToText => "speech_to_text",
                WorkspaceApiKeyResponseModelPermission.ModelsRead => "models_read",
                WorkspaceApiKeyResponseModelPermission.ModelsWrite => "models_write",
                WorkspaceApiKeyResponseModelPermission.VoicesRead => "voices_read",
                WorkspaceApiKeyResponseModelPermission.VoicesWrite => "voices_write",
                WorkspaceApiKeyResponseModelPermission.SpeechHistoryRead => "speech_history_read",
                WorkspaceApiKeyResponseModelPermission.SpeechHistoryWrite => "speech_history_write",
                WorkspaceApiKeyResponseModelPermission.SoundGeneration => "sound_generation",
                WorkspaceApiKeyResponseModelPermission.AudioIsolation => "audio_isolation",
                WorkspaceApiKeyResponseModelPermission.VoiceGeneration => "voice_generation",
                WorkspaceApiKeyResponseModelPermission.DubbingRead => "dubbing_read",
                WorkspaceApiKeyResponseModelPermission.DubbingWrite => "dubbing_write",
                WorkspaceApiKeyResponseModelPermission.PronunciationDictionariesRead => "pronunciation_dictionaries_read",
                WorkspaceApiKeyResponseModelPermission.PronunciationDictionariesWrite => "pronunciation_dictionaries_write",
                WorkspaceApiKeyResponseModelPermission.UserRead => "user_read",
                WorkspaceApiKeyResponseModelPermission.UserWrite => "user_write",
                WorkspaceApiKeyResponseModelPermission.ProjectsRead => "projects_read",
                WorkspaceApiKeyResponseModelPermission.ProjectsWrite => "projects_write",
                WorkspaceApiKeyResponseModelPermission.AudioNativeRead => "audio_native_read",
                WorkspaceApiKeyResponseModelPermission.AudioNativeWrite => "audio_native_write",
                WorkspaceApiKeyResponseModelPermission.WorkspaceRead => "workspace_read",
                WorkspaceApiKeyResponseModelPermission.WorkspaceWrite => "workspace_write",
                WorkspaceApiKeyResponseModelPermission.ForcedAlignment => "forced_alignment",
                WorkspaceApiKeyResponseModelPermission.ConvaiRead => "convai_read",
                WorkspaceApiKeyResponseModelPermission.ConvaiWrite => "convai_write",
                WorkspaceApiKeyResponseModelPermission.MusicGeneration => "music_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceApiKeyResponseModelPermission? ToEnum(string value)
        {
            return value switch
            {
                "text_to_speech" => WorkspaceApiKeyResponseModelPermission.TextToSpeech,
                "speech_to_speech" => WorkspaceApiKeyResponseModelPermission.SpeechToSpeech,
                "speech_to_text" => WorkspaceApiKeyResponseModelPermission.SpeechToText,
                "models_read" => WorkspaceApiKeyResponseModelPermission.ModelsRead,
                "models_write" => WorkspaceApiKeyResponseModelPermission.ModelsWrite,
                "voices_read" => WorkspaceApiKeyResponseModelPermission.VoicesRead,
                "voices_write" => WorkspaceApiKeyResponseModelPermission.VoicesWrite,
                "speech_history_read" => WorkspaceApiKeyResponseModelPermission.SpeechHistoryRead,
                "speech_history_write" => WorkspaceApiKeyResponseModelPermission.SpeechHistoryWrite,
                "sound_generation" => WorkspaceApiKeyResponseModelPermission.SoundGeneration,
                "audio_isolation" => WorkspaceApiKeyResponseModelPermission.AudioIsolation,
                "voice_generation" => WorkspaceApiKeyResponseModelPermission.VoiceGeneration,
                "dubbing_read" => WorkspaceApiKeyResponseModelPermission.DubbingRead,
                "dubbing_write" => WorkspaceApiKeyResponseModelPermission.DubbingWrite,
                "pronunciation_dictionaries_read" => WorkspaceApiKeyResponseModelPermission.PronunciationDictionariesRead,
                "pronunciation_dictionaries_write" => WorkspaceApiKeyResponseModelPermission.PronunciationDictionariesWrite,
                "user_read" => WorkspaceApiKeyResponseModelPermission.UserRead,
                "user_write" => WorkspaceApiKeyResponseModelPermission.UserWrite,
                "projects_read" => WorkspaceApiKeyResponseModelPermission.ProjectsRead,
                "projects_write" => WorkspaceApiKeyResponseModelPermission.ProjectsWrite,
                "audio_native_read" => WorkspaceApiKeyResponseModelPermission.AudioNativeRead,
                "audio_native_write" => WorkspaceApiKeyResponseModelPermission.AudioNativeWrite,
                "workspace_read" => WorkspaceApiKeyResponseModelPermission.WorkspaceRead,
                "workspace_write" => WorkspaceApiKeyResponseModelPermission.WorkspaceWrite,
                "forced_alignment" => WorkspaceApiKeyResponseModelPermission.ForcedAlignment,
                "convai_read" => WorkspaceApiKeyResponseModelPermission.ConvaiRead,
                "convai_write" => WorkspaceApiKeyResponseModelPermission.ConvaiWrite,
                "music_generation" => WorkspaceApiKeyResponseModelPermission.MusicGeneration,
                _ => null,
            };
        }
    }
}