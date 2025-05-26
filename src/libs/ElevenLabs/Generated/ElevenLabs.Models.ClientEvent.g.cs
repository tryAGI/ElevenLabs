
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        AsrInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        Ping,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Interruption,
        /// <summary>
        /// 
        /// </summary>
        UserTranscript,
        /// <summary>
        /// 
        /// </summary>
        AgentResponse,
        /// <summary>
        /// 
        /// </summary>
        AgentResponseCorrection,
        /// <summary>
        /// 
        /// </summary>
        ClientToolCall,
        /// <summary>
        /// 
        /// </summary>
        VadScore,
        /// <summary>
        /// 
        /// </summary>
        InternalTurnProbability,
        /// <summary>
        /// 
        /// </summary>
        InternalTentativeAgentResponse,
        /// <summary>
        /// 
        /// </summary>
        InternalNativeMcpToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientEvent value)
        {
            return value switch
            {
                ClientEvent.ConversationInitiationMetadata => "conversation_initiation_metadata",
                ClientEvent.AsrInitiationMetadata => "asr_initiation_metadata",
                ClientEvent.Ping => "ping",
                ClientEvent.Audio => "audio",
                ClientEvent.Interruption => "interruption",
                ClientEvent.UserTranscript => "user_transcript",
                ClientEvent.AgentResponse => "agent_response",
                ClientEvent.AgentResponseCorrection => "agent_response_correction",
                ClientEvent.ClientToolCall => "client_tool_call",
                ClientEvent.VadScore => "vad_score",
                ClientEvent.InternalTurnProbability => "internal_turn_probability",
                ClientEvent.InternalTentativeAgentResponse => "internal_tentative_agent_response",
                ClientEvent.InternalNativeMcpToolCall => "internal_native_mcp_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientEvent? ToEnum(string value)
        {
            return value switch
            {
                "conversation_initiation_metadata" => ClientEvent.ConversationInitiationMetadata,
                "asr_initiation_metadata" => ClientEvent.AsrInitiationMetadata,
                "ping" => ClientEvent.Ping,
                "audio" => ClientEvent.Audio,
                "interruption" => ClientEvent.Interruption,
                "user_transcript" => ClientEvent.UserTranscript,
                "agent_response" => ClientEvent.AgentResponse,
                "agent_response_correction" => ClientEvent.AgentResponseCorrection,
                "client_tool_call" => ClientEvent.ClientToolCall,
                "vad_score" => ClientEvent.VadScore,
                "internal_turn_probability" => ClientEvent.InternalTurnProbability,
                "internal_tentative_agent_response" => ClientEvent.InternalTentativeAgentResponse,
                "internal_native_mcp_tool_call" => ClientEvent.InternalNativeMcpToolCall,
                _ => null,
            };
        }
    }
}