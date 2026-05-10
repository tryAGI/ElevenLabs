
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextualUpdateInfo
    {
        /// <summary>
        /// Client-supplied identifier grouping related contextual updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// True when this contextual update has been replaced by a newer update with the same context_id.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_superseded")]
        public bool? IsSuperseded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualUpdateInfo" /> class.
        /// </summary>
        /// <param name="contextId">
        /// Client-supplied identifier grouping related contextual updates.
        /// </param>
        /// <param name="isSuperseded">
        /// True when this contextual update has been replaced by a newer update with the same context_id.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextualUpdateInfo(
            string contextId,
            bool? isSuperseded)
        {
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.IsSuperseded = isSuperseded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualUpdateInfo" /> class.
        /// </summary>
        public ContextualUpdateInfo()
        {
        }

    }
}