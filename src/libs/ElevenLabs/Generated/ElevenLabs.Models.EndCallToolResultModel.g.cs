
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndCallToolResultModel
    {
        /// <summary>
        /// Default Value: end_call_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EndCallToolResultModelResultTypeJsonConverter))]
        public global::ElevenLabs.EndCallToolResultModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EndCallToolResultModelStatusJsonConverter))]
        public global::ElevenLabs.EndCallToolResultModelStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndCallToolResultModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: end_call_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndCallToolResultModel(
            global::ElevenLabs.EndCallToolResultModelResultType? resultType,
            global::ElevenLabs.EndCallToolResultModelStatus? status,
            string? reason,
            string? message)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndCallToolResultModel" /> class.
        /// </summary>
        public EndCallToolResultModel()
        {
        }
    }
}