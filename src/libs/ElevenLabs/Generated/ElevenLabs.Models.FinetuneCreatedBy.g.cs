
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneCreatedBy
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Self,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneCreatedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneCreatedBy value)
        {
            return value switch
            {
                FinetuneCreatedBy.Elevenlabs => "elevenlabs",
                FinetuneCreatedBy.Self => "self",
                FinetuneCreatedBy.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneCreatedBy? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => FinetuneCreatedBy.Elevenlabs,
                "self" => FinetuneCreatedBy.Self,
                "workspace" => FinetuneCreatedBy.Workspace,
                _ => null,
            };
        }
    }
}