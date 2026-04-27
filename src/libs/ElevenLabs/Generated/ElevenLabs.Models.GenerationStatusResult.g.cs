
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationStatusResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.GenerationDetail>? Generations { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_completed")]
        public bool? AllCompleted { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_failures")]
        public bool? HasFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResult" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="generations">
        /// Default Value: []
        /// </param>
        /// <param name="allCompleted">
        /// Default Value: false
        /// </param>
        /// <param name="hasFailures">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationStatusResult(
            string sessionId,
            global::System.Collections.Generic.IList<global::ElevenLabs.GenerationDetail>? generations,
            bool? allCompleted,
            bool? hasFailures)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Generations = generations;
            this.AllCompleted = allCompleted;
            this.HasFailures = hasFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResult" /> class.
        /// </summary>
        public GenerationStatusResult()
        {
        }
    }
}