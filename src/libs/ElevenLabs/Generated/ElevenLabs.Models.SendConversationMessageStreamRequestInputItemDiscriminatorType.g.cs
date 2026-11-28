
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SendConversationMessageStreamRequestInputItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ClientToolResult,
        /// <summary>
        ///
        /// </summary>
        ContextualUpdate,
        /// <summary>
        ///
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendConversationMessageStreamRequestInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendConversationMessageStreamRequestInputItemDiscriminatorType value)
        {
            return value switch
            {
                SendConversationMessageStreamRequestInputItemDiscriminatorType.ClientToolResult => "client_tool_result",
                SendConversationMessageStreamRequestInputItemDiscriminatorType.ContextualUpdate => "contextual_update",
                SendConversationMessageStreamRequestInputItemDiscriminatorType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendConversationMessageStreamRequestInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_tool_result" => SendConversationMessageStreamRequestInputItemDiscriminatorType.ClientToolResult,
                "contextual_update" => SendConversationMessageStreamRequestInputItemDiscriminatorType.ContextualUpdate,
                "user_message" => SendConversationMessageStreamRequestInputItemDiscriminatorType.UserMessage,
                _ => null,
            };
        }
    }
}