
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CriterionPerformance
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
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_rate")]
        public double? PassRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Evaluations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend_delta")]
        public double? TrendDelta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionPerformance" /> class.
        /// </summary>
        /// <param name="criterionId"></param>
        /// <param name="criterionName"></param>
        /// <param name="passRate"></param>
        /// <param name="evaluations"></param>
        /// <param name="trendDelta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriterionPerformance(
            string criterionId,
            string criterionName,
            int evaluations,
            double? passRate,
            double? trendDelta)
        {
            this.CriterionId = criterionId ?? throw new global::System.ArgumentNullException(nameof(criterionId));
            this.CriterionName = criterionName ?? throw new global::System.ArgumentNullException(nameof(criterionName));
            this.Evaluations = evaluations;
            this.PassRate = passRate;
            this.TrendDelta = trendDelta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionPerformance" /> class.
        /// </summary>
        public CriterionPerformance()
        {
        }
    }
}