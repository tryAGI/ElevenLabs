
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response from a preflight (dry-run) check.
    /// </summary>
    public sealed partial class NodeRunPreflightResponseModel
    {
        /// <summary>
        /// Total estimated credits across all nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// Total estimated cost in cents across all nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceCents { get; set; }

        /// <summary>
        /// Currency of the cost estimates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_fiat_currency")]
        public string? CostFiatCurrency { get; set; }

        /// <summary>
        /// Per-node preflight details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.NodePreflightInfo> Nodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRunPreflightResponseModel" /> class.
        /// </summary>
        /// <param name="credits">
        /// Total estimated credits across all nodes.
        /// </param>
        /// <param name="priceCents">
        /// Total estimated cost in cents across all nodes.
        /// </param>
        /// <param name="nodes">
        /// Per-node preflight details.
        /// </param>
        /// <param name="costFiatCurrency">
        /// Currency of the cost estimates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeRunPreflightResponseModel(
            double credits,
            double priceCents,
            global::System.Collections.Generic.IList<global::ElevenLabs.NodePreflightInfo> nodes,
            string? costFiatCurrency)
        {
            this.Credits = credits;
            this.PriceCents = priceCents;
            this.CostFiatCurrency = costFiatCurrency;
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRunPreflightResponseModel" /> class.
        /// </summary>
        public NodeRunPreflightResponseModel()
        {
        }

    }
}