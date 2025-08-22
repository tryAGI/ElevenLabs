
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingCancellationResponseModel
    {
        /// <summary>
        /// Default Value: cancellation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PendingCancellationResponseModelKindJsonConverter))]
        public global::ElevenLabs.PendingCancellationResponseModelKind? Kind { get; set; }

        /// <summary>
        /// The timestamp of the cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimestampSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingCancellationResponseModel" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: cancellation
        /// </param>
        /// <param name="timestampSeconds">
        /// The timestamp of the cancellation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingCancellationResponseModel(
            int timestampSeconds,
            global::ElevenLabs.PendingCancellationResponseModelKind? kind)
        {
            this.TimestampSeconds = timestampSeconds;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingCancellationResponseModel" /> class.
        /// </summary>
        public PendingCancellationResponseModel()
        {
        }
    }
}