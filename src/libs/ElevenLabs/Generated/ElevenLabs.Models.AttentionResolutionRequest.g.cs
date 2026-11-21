
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AttentionResolutionRequest
    {
        /// <summary>
        /// How the item was handled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttentionResolutionRequest" /> class.
        /// </summary>
        /// <param name="resolution">
        /// How the item was handled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttentionResolutionRequest(
            string resolution)
        {
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttentionResolutionRequest" /> class.
        /// </summary>
        public AttentionResolutionRequest()
        {
        }

    }
}