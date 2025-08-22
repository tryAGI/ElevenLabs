
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: testing_tool_result
    /// </summary>
    public enum TestToolResultModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TestingToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestToolResultModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestToolResultModelResultType value)
        {
            return value switch
            {
                TestToolResultModelResultType.TestingToolResult => "testing_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestToolResultModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "testing_tool_result" => TestToolResultModelResultType.TestingToolResult,
                _ => null,
            };
        }
    }
}