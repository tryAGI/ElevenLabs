
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSharedSoundGenerationsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_sound_generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SharedSoundGenerationResponseModel> SharedSoundGenerations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sort_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? LastSortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSharedSoundGenerationsResponseModel" /> class.
        /// </summary>
        /// <param name="sharedSoundGenerations"></param>
        /// <param name="lastSortId"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSharedSoundGenerationsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.SharedSoundGenerationResponseModel> sharedSoundGenerations,
            string? lastSortId,
            bool hasMore)
        {
            this.SharedSoundGenerations = sharedSoundGenerations ?? throw new global::System.ArgumentNullException(nameof(sharedSoundGenerations));
            this.LastSortId = lastSortId ?? throw new global::System.ArgumentNullException(nameof(lastSortId));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSharedSoundGenerationsResponseModel" /> class.
        /// </summary>
        public GetSharedSoundGenerationsResponseModel()
        {
        }
    }
}