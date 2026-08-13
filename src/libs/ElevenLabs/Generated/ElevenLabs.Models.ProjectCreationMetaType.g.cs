
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectCreationMetaType
    {
        /// <summary>
        /// 
        /// </summary>
        AutoAssignVoices,
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        DubVideo,
        /// <summary>
        /// 
        /// </summary>
        GeneratePodcast,
        /// <summary>
        /// 
        /// </summary>
        ImportSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectCreationMetaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectCreationMetaType value)
        {
            return value switch
            {
                ProjectCreationMetaType.AutoAssignVoices => "auto_assign_voices",
                ProjectCreationMetaType.Blank => "blank",
                ProjectCreationMetaType.DubVideo => "dub_video",
                ProjectCreationMetaType.GeneratePodcast => "generate_podcast",
                ProjectCreationMetaType.ImportSpeech => "import_speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectCreationMetaType? ToEnum(string value)
        {
            return value switch
            {
                "auto_assign_voices" => ProjectCreationMetaType.AutoAssignVoices,
                "blank" => ProjectCreationMetaType.Blank,
                "dub_video" => ProjectCreationMetaType.DubVideo,
                "generate_podcast" => ProjectCreationMetaType.GeneratePodcast,
                "import_speech" => ProjectCreationMetaType.ImportSpeech,
                _ => null,
            };
        }
    }
}