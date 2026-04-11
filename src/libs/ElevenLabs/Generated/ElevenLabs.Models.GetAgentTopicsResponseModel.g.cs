
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentTopicsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel> Topics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_start_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowStartUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_end_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowEndUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTopicsResponseModel" /> class.
        /// </summary>
        /// <param name="topics"></param>
        /// <param name="windowStartUnixSecs"></param>
        /// <param name="windowEndUnixSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentTopicsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel> topics,
            int windowStartUnixSecs,
            int windowEndUnixSecs)
        {
            this.Topics = topics ?? throw new global::System.ArgumentNullException(nameof(topics));
            this.WindowStartUnixSecs = windowStartUnixSecs;
            this.WindowEndUnixSecs = windowEndUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTopicsResponseModel" /> class.
        /// </summary>
        public GetAgentTopicsResponseModel()
        {
        }
    }
}