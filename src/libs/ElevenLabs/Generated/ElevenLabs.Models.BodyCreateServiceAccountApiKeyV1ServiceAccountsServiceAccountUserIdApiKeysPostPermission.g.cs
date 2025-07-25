
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission value)
        {
            return value switch
            {
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.TextToSpeech => "text_to_speech",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechToSpeech => "speech_to_speech",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechToText => "speech_to_text",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ModelsRead => "models_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ModelsWrite => "models_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.VoicesRead => "voices_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.VoicesWrite => "voices_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechHistoryRead => "speech_history_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechHistoryWrite => "speech_history_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SoundGeneration => "sound_generation",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.AudioIsolation => "audio_isolation",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.VoiceGeneration => "voice_generation",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.DubbingRead => "dubbing_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.DubbingWrite => "dubbing_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.PronunciationDictionariesRead => "pronunciation_dictionaries_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.PronunciationDictionariesWrite => "pronunciation_dictionaries_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.UserRead => "user_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.UserWrite => "user_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ProjectsRead => "projects_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ProjectsWrite => "projects_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.AudioNativeRead => "audio_native_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.AudioNativeWrite => "audio_native_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.WorkspaceRead => "workspace_read",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.WorkspaceWrite => "workspace_write",
                BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ForcedAlignment => "forced_alignment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission? ToEnum(string value)
        {
            return value switch
            {
                "text_to_speech" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.TextToSpeech,
                "speech_to_speech" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechToSpeech,
                "speech_to_text" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechToText,
                "models_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ModelsRead,
                "models_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ModelsWrite,
                "voices_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.VoicesRead,
                "voices_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.VoicesWrite,
                "speech_history_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechHistoryRead,
                "speech_history_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SpeechHistoryWrite,
                "sound_generation" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.SoundGeneration,
                "audio_isolation" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.AudioIsolation,
                "voice_generation" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.VoiceGeneration,
                "dubbing_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.DubbingRead,
                "dubbing_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.DubbingWrite,
                "pronunciation_dictionaries_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.PronunciationDictionariesRead,
                "pronunciation_dictionaries_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.PronunciationDictionariesWrite,
                "user_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.UserRead,
                "user_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.UserWrite,
                "projects_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ProjectsRead,
                "projects_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ProjectsWrite,
                "audio_native_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.AudioNativeRead,
                "audio_native_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.AudioNativeWrite,
                "workspace_read" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.WorkspaceRead,
                "workspace_write" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.WorkspaceWrite,
                "forced_alignment" => BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPostPermission.ForcedAlignment,
                _ => null,
            };
        }
    }
}