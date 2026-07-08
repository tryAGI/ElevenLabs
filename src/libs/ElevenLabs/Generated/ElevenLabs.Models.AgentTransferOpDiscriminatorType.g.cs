
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentTransferOpDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Pop,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTransferOpDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferOpDiscriminatorType value)
        {
            return value switch
            {
                AgentTransferOpDiscriminatorType.Pop => "pop",
                AgentTransferOpDiscriminatorType.Push => "push",
                AgentTransferOpDiscriminatorType.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferOpDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "pop" => AgentTransferOpDiscriminatorType.Pop,
                "push" => AgentTransferOpDiscriminatorType.Push,
                "replace" => AgentTransferOpDiscriminatorType.Replace,
                _ => null,
            };
        }
    }
}