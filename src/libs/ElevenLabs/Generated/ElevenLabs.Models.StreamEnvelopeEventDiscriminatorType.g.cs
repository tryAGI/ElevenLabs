
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum StreamEnvelopeEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentChatResponsePart,
        /// <summary>
        ///
        /// </summary>
        AgentReasoningResponsePart,
        /// <summary>
        ///
        /// </summary>
        AgentResponse,
        /// <summary>
        ///
        /// </summary>
        AgentToolRequest,
        /// <summary>
        ///
        /// </summary>
        AgentToolResponse,
        /// <summary>
        ///
        /// </summary>
        ClientToolCall,
        /// <summary>
        ///
        /// </summary>
        StreamEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamEnvelopeEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamEnvelopeEventDiscriminatorType value)
        {
            return value switch
            {
                StreamEnvelopeEventDiscriminatorType.AgentChatResponsePart => "agent_chat_response_part",
                StreamEnvelopeEventDiscriminatorType.AgentReasoningResponsePart => "agent_reasoning_response_part",
                StreamEnvelopeEventDiscriminatorType.AgentResponse => "agent_response",
                StreamEnvelopeEventDiscriminatorType.AgentToolRequest => "agent_tool_request",
                StreamEnvelopeEventDiscriminatorType.AgentToolResponse => "agent_tool_response",
                StreamEnvelopeEventDiscriminatorType.ClientToolCall => "client_tool_call",
                StreamEnvelopeEventDiscriminatorType.StreamEnded => "stream_ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamEnvelopeEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_chat_response_part" => StreamEnvelopeEventDiscriminatorType.AgentChatResponsePart,
                "agent_reasoning_response_part" => StreamEnvelopeEventDiscriminatorType.AgentReasoningResponsePart,
                "agent_response" => StreamEnvelopeEventDiscriminatorType.AgentResponse,
                "agent_tool_request" => StreamEnvelopeEventDiscriminatorType.AgentToolRequest,
                "agent_tool_response" => StreamEnvelopeEventDiscriminatorType.AgentToolResponse,
                "client_tool_call" => StreamEnvelopeEventDiscriminatorType.ClientToolCall,
                "stream_ended" => StreamEnvelopeEventDiscriminatorType.StreamEnded,
                _ => null,
            };
        }
    }
}