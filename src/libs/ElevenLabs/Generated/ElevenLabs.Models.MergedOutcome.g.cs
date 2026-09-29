
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MergedOutcome
    {
        /// <summary>
        /// Default Value: merged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int At { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_user_id")]
        public string? ByUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedOutcome" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="at"></param>
        /// <param name="status">
        /// Default Value: merged
        /// </param>
        /// <param name="byUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergedOutcome(
            string versionId,
            int at,
            string? status,
            string? byUserId)
        {
            this.Status = status;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.At = at;
            this.ByUserId = byUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedOutcome" /> class.
        /// </summary>
        public MergedOutcome()
        {
        }

    }
}