
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionExtrasResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConvaiConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_logging_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForceLoggingDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModerationStatusResponseModel Moderation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        /// <param name="concurrency"></param>
        /// <param name="convaiConcurrency"></param>
        /// <param name="forceLoggingDisabled"></param>
        /// <param name="moderation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SubscriptionExtrasResponseModel(
            int concurrency,
            int convaiConcurrency,
            bool forceLoggingDisabled,
            global::ElevenLabs.ModerationStatusResponseModel moderation)
        {
            this.Concurrency = concurrency;
            this.ConvaiConcurrency = convaiConcurrency;
            this.ForceLoggingDisabled = forceLoggingDisabled;
            this.Moderation = moderation ?? throw new global::System.ArgumentNullException(nameof(moderation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        public SubscriptionExtrasResponseModel()
        {
        }
    }
}