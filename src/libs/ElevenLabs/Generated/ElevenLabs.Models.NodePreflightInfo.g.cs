
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Preflight info for a single node that would run.
    /// </summary>
    public sealed partial class NodePreflightInfo
    {
        /// <summary>
        /// ID of the template node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateNodeId { get; set; }

        /// <summary>
        /// Why this node would run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.NodeRunReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.NodeRunReason RunReason { get; set; }

        /// <summary>
        /// Estimated credit cost for this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Estimated cost in cents for this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_cents")]
        public double? PriceCents { get; set; }

        /// <summary>
        /// Currency of the estimated cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_fiat_currency")]
        public string? CostFiatCurrency { get; set; }

        /// <summary>
        /// Soft errors detected for this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.NodePreflightError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePreflightInfo" /> class.
        /// </summary>
        /// <param name="templateNodeId">
        /// ID of the template node.
        /// </param>
        /// <param name="runReason">
        /// Why this node would run.
        /// </param>
        /// <param name="credits">
        /// Estimated credit cost for this node.
        /// </param>
        /// <param name="priceCents">
        /// Estimated cost in cents for this node.
        /// </param>
        /// <param name="costFiatCurrency">
        /// Currency of the estimated cost.
        /// </param>
        /// <param name="errors">
        /// Soft errors detected for this node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodePreflightInfo(
            string templateNodeId,
            global::ElevenLabs.NodeRunReason runReason,
            double? credits,
            double? priceCents,
            string? costFiatCurrency,
            global::System.Collections.Generic.IList<global::ElevenLabs.NodePreflightError>? errors)
        {
            this.TemplateNodeId = templateNodeId ?? throw new global::System.ArgumentNullException(nameof(templateNodeId));
            this.RunReason = runReason;
            this.Credits = credits;
            this.PriceCents = priceCents;
            this.CostFiatCurrency = costFiatCurrency;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePreflightInfo" /> class.
        /// </summary>
        public NodePreflightInfo()
        {
        }

    }
}