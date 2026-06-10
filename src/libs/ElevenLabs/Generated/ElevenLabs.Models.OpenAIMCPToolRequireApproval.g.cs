
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: never
    /// </summary>
    public enum OpenAIMCPToolRequireApproval
    {
        /// <summary>
        /// 
        /// </summary>
        Always,
        /// <summary>
        /// 
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIMCPToolRequireApprovalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIMCPToolRequireApproval value)
        {
            return value switch
            {
                OpenAIMCPToolRequireApproval.Always => "always",
                OpenAIMCPToolRequireApproval.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIMCPToolRequireApproval? ToEnum(string value)
        {
            return value switch
            {
                "always" => OpenAIMCPToolRequireApproval.Always,
                "never" => OpenAIMCPToolRequireApproval.Never,
                _ => null,
            };
        }
    }
}