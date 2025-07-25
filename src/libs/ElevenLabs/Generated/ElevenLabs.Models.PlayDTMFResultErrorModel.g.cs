
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlayDTMFResultErrorModel
    {
        /// <summary>
        /// Default Value: play_dtmf_error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PlayDTMFResultErrorModelResultTypeJsonConverter))]
        public global::ElevenLabs.PlayDTMFResultErrorModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PlayDTMFResultErrorModelStatusJsonConverter))]
        public global::ElevenLabs.PlayDTMFResultErrorModelStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFResultErrorModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: play_dtmf_error
        /// </param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
        /// <param name="error"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlayDTMFResultErrorModel(
            string error,
            global::ElevenLabs.PlayDTMFResultErrorModelResultType? resultType,
            global::ElevenLabs.PlayDTMFResultErrorModelStatus? status,
            string? details)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ResultType = resultType;
            this.Status = status;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFResultErrorModel" /> class.
        /// </summary>
        public PlayDTMFResultErrorModel()
        {
        }
    }
}