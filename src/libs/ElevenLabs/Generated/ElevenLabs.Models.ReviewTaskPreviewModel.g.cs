
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewTaskPreviewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ReviewStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReviewState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public double? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TagDbModel> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounty_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BountyUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Deadline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewTaskPreviewModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="durationSecs"></param>
        /// <param name="tags"></param>
        /// <param name="bountyUsd"></param>
        /// <param name="deadline"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewTaskPreviewModel(
            string id,
            global::ElevenLabs.ReviewState state,
            global::System.Collections.Generic.IList<global::ElevenLabs.TagDbModel> tags,
            double bountyUsd,
            global::System.DateTime deadline,
            double? durationSecs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.State = state;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.BountyUsd = bountyUsd;
            this.Deadline = deadline;
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewTaskPreviewModel" /> class.
        /// </summary>
        public ReviewTaskPreviewModel()
        {
        }
    }
}