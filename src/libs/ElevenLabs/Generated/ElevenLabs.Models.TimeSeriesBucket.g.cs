
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeSeriesBucket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Dt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_scores")]
        public int? SuccessScores { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_scores")]
        public int? TotalScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesBucket" /> class.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="successScores">
        /// Default Value: 0
        /// </param>
        /// <param name="totalScores">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeSeriesBucket(
            int dt,
            int completed,
            int failed,
            int? successScores,
            int? totalScores)
        {
            this.Dt = dt;
            this.Completed = completed;
            this.Failed = failed;
            this.SuccessScores = successScores;
            this.TotalScores = totalScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesBucket" /> class.
        /// </summary>
        public TimeSeriesBucket()
        {
        }
    }
}