
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CriterionBreakdown
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriterionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriterionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unknown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_call_duration_seconds")]
        public double? AvgCallDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionBreakdown" /> class.
        /// </summary>
        /// <param name="criterionId"></param>
        /// <param name="criterionName"></param>
        /// <param name="total"></param>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="unknown"></param>
        /// <param name="avgCallDurationSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriterionBreakdown(
            string criterionId,
            string criterionName,
            int total,
            int success,
            int failure,
            int unknown,
            double? avgCallDurationSeconds)
        {
            this.CriterionId = criterionId ?? throw new global::System.ArgumentNullException(nameof(criterionId));
            this.CriterionName = criterionName ?? throw new global::System.ArgumentNullException(nameof(criterionName));
            this.Total = total;
            this.Success = success;
            this.Failure = failure;
            this.Unknown = unknown;
            this.AvgCallDurationSeconds = avgCallDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionBreakdown" /> class.
        /// </summary>
        public CriterionBreakdown()
        {
        }
    }
}