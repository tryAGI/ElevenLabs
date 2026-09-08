
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Unified container for all platform limits.<br/>
    /// Can be used by:<br/>
    /// - Billing groups (WorkspaceGroupDBModel.platform_limits)<br/>
    /// - Child workspaces (SubscriptionDBModel.platform_limits)<br/>
    /// - API keys (XiApiKeyMetadataDBModel.platform_limits)<br/>
    /// All fields are required when platform_limits exists. Use limit=None for unlimited.
    /// </summary>
    public sealed partial class PlatformLimits
    {
        /// <summary>
        /// Credit usage limit (limit=None means unlimited)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::ElevenLabs.StoredUsagePlatformLimit? Credits { get; set; }

        /// <summary>
        /// Professional Voice Clone count limit (limit=None means unlimited)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pvc")]
        public global::ElevenLabs.ComputedUsagePlatformLimit? Pvc { get; set; }

        /// <summary>
        /// TTS concurrency limit (limit=None means unlimited)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public global::ElevenLabs.ComputedUsagePlatformLimit? Concurrency { get; set; }

        /// <summary>
        /// Dubbing concurrency limit (limit=None means unlimited)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_concurrency")]
        public global::ElevenLabs.ComputedUsagePlatformLimit? DubbingConcurrency { get; set; }

        /// <summary>
        /// Music generation concurrency limit (limit=None means unlimited)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_concurrency")]
        public global::ElevenLabs.ComputedUsagePlatformLimit? MusicConcurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformLimits" /> class.
        /// </summary>
        /// <param name="credits">
        /// Credit usage limit (limit=None means unlimited)
        /// </param>
        /// <param name="pvc">
        /// Professional Voice Clone count limit (limit=None means unlimited)
        /// </param>
        /// <param name="concurrency">
        /// TTS concurrency limit (limit=None means unlimited)
        /// </param>
        /// <param name="dubbingConcurrency">
        /// Dubbing concurrency limit (limit=None means unlimited)
        /// </param>
        /// <param name="musicConcurrency">
        /// Music generation concurrency limit (limit=None means unlimited)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlatformLimits(
            global::ElevenLabs.StoredUsagePlatformLimit? credits,
            global::ElevenLabs.ComputedUsagePlatformLimit? pvc,
            global::ElevenLabs.ComputedUsagePlatformLimit? concurrency,
            global::ElevenLabs.ComputedUsagePlatformLimit? dubbingConcurrency,
            global::ElevenLabs.ComputedUsagePlatformLimit? musicConcurrency)
        {
            this.Credits = credits;
            this.Pvc = pvc;
            this.Concurrency = concurrency;
            this.DubbingConcurrency = dubbingConcurrency;
            this.MusicConcurrency = musicConcurrency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformLimits" /> class.
        /// </summary>
        public PlatformLimits()
        {
        }

    }
}