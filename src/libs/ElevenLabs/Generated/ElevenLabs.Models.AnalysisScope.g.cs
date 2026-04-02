
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: conversation
    /// </summary>
    public enum AnalysisScope
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisScope value)
        {
            return value switch
            {
                AnalysisScope.Agent => "agent",
                AnalysisScope.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisScope? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AnalysisScope.Agent,
                "conversation" => AnalysisScope.Conversation,
                _ => null,
            };
        }
    }
}