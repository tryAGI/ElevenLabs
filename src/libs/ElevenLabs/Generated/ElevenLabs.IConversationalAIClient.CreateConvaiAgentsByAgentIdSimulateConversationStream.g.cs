#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Simulates A Conversation (Stream)<br/>
        /// Run a conversation between the agent and a simulated user and stream back the response. Response is streamed back as partial lists of messages that should be concatenated and once the conversation has complete a single final message with the conversation analysis will be sent.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateConvaiAgentsByAgentIdSimulateConversationStreamAsync(
            string agentId,
            global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Simulates A Conversation (Stream)<br/>
        /// Run a conversation between the agent and a simulated user and stream back the response. Response is streamed back as partial lists of messages that should be concatenated and once the conversation has complete a single final message with the conversation analysis will be sent.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="simulationSpecification">
        /// A specification that will be used to simulate a conversation between an agent and an AI user.
        /// </param>
        /// <param name="extraEvaluationCriteria">
        /// A list of evaluation criteria to test
        /// </param>
        /// <param name="newTurnsLimit">
        /// Maximum number of new turns to generate in the conversation simulation<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateConvaiAgentsByAgentIdSimulateConversationStreamAsync(
            string agentId,
            global::ElevenLabs.ConversationSimulationSpecification simulationSpecification,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? extraEvaluationCriteria = default,
            int? newTurnsLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}