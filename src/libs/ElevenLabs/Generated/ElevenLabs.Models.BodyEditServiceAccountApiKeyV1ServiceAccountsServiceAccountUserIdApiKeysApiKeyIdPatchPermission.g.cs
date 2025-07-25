
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission
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
    public static class BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission value)
        {
            return value switch
            {
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.TextToSpeech => "text_to_speech",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechToSpeech => "speech_to_speech",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechToText => "speech_to_text",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ModelsRead => "models_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ModelsWrite => "models_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.VoicesRead => "voices_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.VoicesWrite => "voices_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechHistoryRead => "speech_history_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechHistoryWrite => "speech_history_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SoundGeneration => "sound_generation",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.AudioIsolation => "audio_isolation",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.VoiceGeneration => "voice_generation",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.DubbingRead => "dubbing_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.DubbingWrite => "dubbing_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.PronunciationDictionariesRead => "pronunciation_dictionaries_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.PronunciationDictionariesWrite => "pronunciation_dictionaries_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.UserRead => "user_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.UserWrite => "user_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ProjectsRead => "projects_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ProjectsWrite => "projects_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.AudioNativeRead => "audio_native_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.AudioNativeWrite => "audio_native_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.WorkspaceRead => "workspace_read",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.WorkspaceWrite => "workspace_write",
                BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ForcedAlignment => "forced_alignment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission? ToEnum(string value)
        {
            return value switch
            {
                "text_to_speech" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.TextToSpeech,
                "speech_to_speech" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechToSpeech,
                "speech_to_text" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechToText,
                "models_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ModelsRead,
                "models_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ModelsWrite,
                "voices_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.VoicesRead,
                "voices_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.VoicesWrite,
                "speech_history_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechHistoryRead,
                "speech_history_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SpeechHistoryWrite,
                "sound_generation" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.SoundGeneration,
                "audio_isolation" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.AudioIsolation,
                "voice_generation" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.VoiceGeneration,
                "dubbing_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.DubbingRead,
                "dubbing_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.DubbingWrite,
                "pronunciation_dictionaries_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.PronunciationDictionariesRead,
                "pronunciation_dictionaries_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.PronunciationDictionariesWrite,
                "user_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.UserRead,
                "user_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.UserWrite,
                "projects_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ProjectsRead,
                "projects_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ProjectsWrite,
                "audio_native_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.AudioNativeRead,
                "audio_native_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.AudioNativeWrite,
                "workspace_read" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.WorkspaceRead,
                "workspace_write" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.WorkspaceWrite,
                "forced_alignment" => BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermission.ForcedAlignment,
                _ => null,
            };
        }
    }
}