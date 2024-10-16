
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExtendedResponseModelTargetAudience
    {
        /// <summary>
        /// 
        /// </summary>
        Children,
        /// <summary>
        /// 
        /// </summary>
        YoungAdult,
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        AllAges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelTargetAudience value)
        {
            return value switch
            {
                ProjectExtendedResponseModelTargetAudience.Children => "children",
                ProjectExtendedResponseModelTargetAudience.YoungAdult => "young adult",
                ProjectExtendedResponseModelTargetAudience.Adult => "adult",
                ProjectExtendedResponseModelTargetAudience.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelTargetAudience? ToEnum(string value)
        {
            return value switch
            {
                "children" => ProjectExtendedResponseModelTargetAudience.Children,
                "young adult" => ProjectExtendedResponseModelTargetAudience.YoungAdult,
                "adult" => ProjectExtendedResponseModelTargetAudience.Adult,
                "all ages" => ProjectExtendedResponseModelTargetAudience.AllAges,
                _ => null,
            };
        }
    }
}