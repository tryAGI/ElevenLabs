
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A failed media generation and why it failed.<br/>
    /// Example: {"error_message":"Timed out while processing. You were not charged for this generation.","failure_reason":"timeout","id":"JWr5N6X9ZTqf8jD2LmQb","status":"failed"}
    /// </summary>
    public sealed partial class MediaGenerationFailedResponse
    {
        /// <summary>
        /// The unique identifier of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The lifecycle status of the generation.
        /// </summary>
        /// <default>"failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "failed";

        /// <summary>
        /// The category of failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MediaGenerationFailedResponseFailureReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MediaGenerationFailedResponseFailureReason FailureReason { get; set; }

        /// <summary>
        /// A human-readable description of the failure. Failed generations are not charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationFailedResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the generation.
        /// </param>
        /// <param name="failureReason">
        /// The category of failure.
        /// </param>
        /// <param name="errorMessage">
        /// A human-readable description of the failure. Failed generations are not charged.
        /// </param>
        /// <param name="status">
        /// The lifecycle status of the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaGenerationFailedResponse(
            string id,
            global::ElevenLabs.MediaGenerationFailedResponseFailureReason failureReason,
            string errorMessage,
            string status = "failed")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.FailureReason = failureReason;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationFailedResponse" /> class.
        /// </summary>
        public MediaGenerationFailedResponse()
        {
        }

    }
}