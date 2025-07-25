
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkipTurnToolResponseModel
    {
        /// <summary>
        /// Default Value: skip_turn_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SkipTurnToolResponseModelResultTypeJsonConverter))]
        public global::ElevenLabs.SkipTurnToolResponseModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SkipTurnToolResponseModelStatusJsonConverter))]
        public global::ElevenLabs.SkipTurnToolResponseModelStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolResponseModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: skip_turn_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkipTurnToolResponseModel(
            global::ElevenLabs.SkipTurnToolResponseModelResultType? resultType,
            global::ElevenLabs.SkipTurnToolResponseModelStatus? status,
            string? reason)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolResponseModel" /> class.
        /// </summary>
        public SkipTurnToolResponseModel()
        {
        }
    }
}