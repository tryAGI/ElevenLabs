
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneVisibility value)
        {
            return value switch
            {
                FinetuneVisibility.Private => "private",
                FinetuneVisibility.Public => "public",
                FinetuneVisibility.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => FinetuneVisibility.Private,
                "public" => FinetuneVisibility.Public,
                "workspace" => FinetuneVisibility.Workspace,
                _ => null,
            };
        }
    }
}