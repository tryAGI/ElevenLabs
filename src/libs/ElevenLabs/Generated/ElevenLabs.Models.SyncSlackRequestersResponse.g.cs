
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SyncSlackRequestersResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("existing_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExistingCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkippedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncSlackRequestersResponse" /> class.
        /// </summary>
        /// <param name="createdCount"></param>
        /// <param name="existingCount"></param>
        /// <param name="skippedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncSlackRequestersResponse(
            int createdCount,
            int existingCount,
            int skippedCount)
        {
            this.CreatedCount = createdCount;
            this.ExistingCount = existingCount;
            this.SkippedCount = skippedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncSlackRequestersResponse" /> class.
        /// </summary>
        public SyncSlackRequestersResponse()
        {
        }

    }
}