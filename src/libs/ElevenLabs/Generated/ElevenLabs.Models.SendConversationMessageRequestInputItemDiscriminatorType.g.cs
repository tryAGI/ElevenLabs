
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SendConversationMessageRequestInputItemDiscriminatorType
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
    public static class SendConversationMessageRequestInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendConversationMessageRequestInputItemDiscriminatorType value)
        {
            return value switch
            {
                SendConversationMessageRequestInputItemDiscriminatorType.ClientToolResult => "client_tool_result",
                SendConversationMessageRequestInputItemDiscriminatorType.ContextualUpdate => "contextual_update",
                SendConversationMessageRequestInputItemDiscriminatorType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendConversationMessageRequestInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client_tool_result" => SendConversationMessageRequestInputItemDiscriminatorType.ClientToolResult,
                "contextual_update" => SendConversationMessageRequestInputItemDiscriminatorType.ContextualUpdate,
                "user_message" => SendConversationMessageRequestInputItemDiscriminatorType.UserMessage,
                _ => null,
            };
        }
    }
}