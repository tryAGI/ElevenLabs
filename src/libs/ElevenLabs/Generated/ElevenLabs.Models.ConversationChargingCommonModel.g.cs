
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationChargingCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev_discount")]
        public bool? DevDiscount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChargingCommonModel" /> class.
        /// </summary>
        /// <param name="devDiscount">
        /// Default Value: false
        /// </param>
        /// <param name="tier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationChargingCommonModel(
            bool? devDiscount,
            string? tier)
        {
            this.DevDiscount = devDiscount;
            this.Tier = tier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChargingCommonModel" /> class.
        /// </summary>
        public ConversationChargingCommonModel()
        {
        }
    }
}