
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"multiplier":1.1}
    /// </summary>
    public sealed partial class RegionalProcessingSurchargeInfo
    {
        /// <summary>
        /// The surcharge multiplier applied to this model's pricing (e.g. 1.1 for a 10% surcharge).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiplier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Multiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalProcessingSurchargeInfo" /> class.
        /// </summary>
        /// <param name="multiplier">
        /// The surcharge multiplier applied to this model's pricing (e.g. 1.1 for a 10% surcharge).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionalProcessingSurchargeInfo(
            double multiplier)
        {
            this.Multiplier = multiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalProcessingSurchargeInfo" /> class.
        /// </summary>
        public RegionalProcessingSurchargeInfo()
        {
        }

    }
}