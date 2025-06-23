
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceGroupPermission
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
        VoiceLab,
        /// <summary>
        /// 
        /// </summary>
        SoundEffects,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        VoiceoverStudio,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        AudioNative,
        /// <summary>
        /// 
        /// </summary>
        ConversationalAi,
        /// <summary>
        /// 
        /// </summary>
        VoiceIsolator,
        /// <summary>
        /// 
        /// </summary>
        AiSpeechClassifier,
        /// <summary>
        /// 
        /// </summary>
        AddVoiceFromVoiceLibrary,
        /// <summary>
        /// 
        /// </summary>
        CreateInstantVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        CreateProfessionalVoiceClone,
        /// <summary>
        /// 
        /// </summary>
        CreateUserApiKey,
        /// <summary>
        /// 
        /// </summary>
        PublishStudioProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceGroupPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceGroupPermission value)
        {
            return value switch
            {
                WorkspaceGroupPermission.TextToSpeech => "text_to_speech",
                WorkspaceGroupPermission.SpeechToSpeech => "speech_to_speech",
                WorkspaceGroupPermission.VoiceLab => "voice_lab",
                WorkspaceGroupPermission.SoundEffects => "sound_effects",
                WorkspaceGroupPermission.Projects => "projects",
                WorkspaceGroupPermission.VoiceoverStudio => "voiceover_studio",
                WorkspaceGroupPermission.Dubbing => "dubbing",
                WorkspaceGroupPermission.AudioNative => "audio_native",
                WorkspaceGroupPermission.ConversationalAi => "conversational_ai",
                WorkspaceGroupPermission.VoiceIsolator => "voice_isolator",
                WorkspaceGroupPermission.AiSpeechClassifier => "ai_speech_classifier",
                WorkspaceGroupPermission.AddVoiceFromVoiceLibrary => "add_voice_from_voice_library",
                WorkspaceGroupPermission.CreateInstantVoiceClone => "create_instant_voice_clone",
                WorkspaceGroupPermission.CreateProfessionalVoiceClone => "create_professional_voice_clone",
                WorkspaceGroupPermission.CreateUserApiKey => "create_user_api_key",
                WorkspaceGroupPermission.PublishStudioProject => "publish_studio_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceGroupPermission? ToEnum(string value)
        {
            return value switch
            {
                "text_to_speech" => WorkspaceGroupPermission.TextToSpeech,
                "speech_to_speech" => WorkspaceGroupPermission.SpeechToSpeech,
                "voice_lab" => WorkspaceGroupPermission.VoiceLab,
                "sound_effects" => WorkspaceGroupPermission.SoundEffects,
                "projects" => WorkspaceGroupPermission.Projects,
                "voiceover_studio" => WorkspaceGroupPermission.VoiceoverStudio,
                "dubbing" => WorkspaceGroupPermission.Dubbing,
                "audio_native" => WorkspaceGroupPermission.AudioNative,
                "conversational_ai" => WorkspaceGroupPermission.ConversationalAi,
                "voice_isolator" => WorkspaceGroupPermission.VoiceIsolator,
                "ai_speech_classifier" => WorkspaceGroupPermission.AiSpeechClassifier,
                "add_voice_from_voice_library" => WorkspaceGroupPermission.AddVoiceFromVoiceLibrary,
                "create_instant_voice_clone" => WorkspaceGroupPermission.CreateInstantVoiceClone,
                "create_professional_voice_clone" => WorkspaceGroupPermission.CreateProfessionalVoiceClone,
                "create_user_api_key" => WorkspaceGroupPermission.CreateUserApiKey,
                "publish_studio_project" => WorkspaceGroupPermission.PublishStudioProject,
                _ => null,
            };
        }
    }
}