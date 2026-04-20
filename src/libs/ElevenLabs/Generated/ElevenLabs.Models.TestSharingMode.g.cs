
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestSharingMode
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        SharedWithMe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSharingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSharingMode value)
        {
            return value switch
            {
                TestSharingMode.All => "all",
                TestSharingMode.SharedWithMe => "shared_with_me",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSharingMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => TestSharingMode.All,
                "shared_with_me" => TestSharingMode.SharedWithMe,
                _ => null,
            };
        }
    }
}