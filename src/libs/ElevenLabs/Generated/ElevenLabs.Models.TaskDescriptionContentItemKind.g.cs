
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskDescriptionContentItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        TaskDescription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskDescriptionContentItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskDescriptionContentItemKind value)
        {
            return value switch
            {
                TaskDescriptionContentItemKind.TaskDescription => "task_description",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskDescriptionContentItemKind? ToEnum(string value)
        {
            return value switch
            {
                "task_description" => TaskDescriptionContentItemKind.TaskDescription,
                _ => null,
            };
        }
    }
}