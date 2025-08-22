
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingSubscriptionSwitchResponseModel
    {
        /// <summary>
        /// Default Value: change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelKindJsonConverter))]
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModelKind? Kind { get; set; }

        /// <summary>
        /// The tier to change to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier NextTier { get; set; }

        /// <summary>
        /// The timestamp of the change.
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
        /// Initializes a new instance of the <see cref="PendingSubscriptionSwitchResponseModel" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: change
        /// </param>
        /// <param name="nextTier">
        /// The tier to change to.
        /// </param>
        /// <param name="timestampSeconds">
        /// The timestamp of the change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingSubscriptionSwitchResponseModel(
            global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier nextTier,
            int timestampSeconds,
            global::ElevenLabs.PendingSubscriptionSwitchResponseModelKind? kind)
        {
            this.NextTier = nextTier;
            this.TimestampSeconds = timestampSeconds;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingSubscriptionSwitchResponseModel" /> class.
        /// </summary>
        public PendingSubscriptionSwitchResponseModel()
        {
        }
    }
}