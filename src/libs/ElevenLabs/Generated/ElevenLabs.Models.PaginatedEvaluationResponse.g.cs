
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedEvaluationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationResponse> Evaluations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedEvaluationResponse" /> class.
        /// </summary>
        /// <param name="evaluations"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedEvaluationResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationResponse> evaluations,
            string? nextCursor)
        {
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedEvaluationResponse" /> class.
        /// </summary>
        public PaginatedEvaluationResponse()
        {
        }
    }
}