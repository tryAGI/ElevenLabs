
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultErrorModel
    {
        /// <summary>
        /// Default Value: transfer_to_agent_error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultErrorModelResultTypeJsonConverter))]
        public global::ElevenLabs.TransferToAgentToolResultErrorModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultErrorModelStatusJsonConverter))]
        public global::ElevenLabs.TransferToAgentToolResultErrorModelStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultErrorModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: transfer_to_agent_error
        /// </param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
        /// <param name="fromAgent"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToAgentToolResultErrorModel(
            string fromAgent,
            string error,
            global::ElevenLabs.TransferToAgentToolResultErrorModelResultType? resultType,
            global::ElevenLabs.TransferToAgentToolResultErrorModelStatus? status)
        {
            this.FromAgent = fromAgent ?? throw new global::System.ArgumentNullException(nameof(fromAgent));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ResultType = resultType;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultErrorModel" /> class.
        /// </summary>
        public TransferToAgentToolResultErrorModel()
        {
        }
    }
}