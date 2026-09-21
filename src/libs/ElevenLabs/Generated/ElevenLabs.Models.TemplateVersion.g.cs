
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A published snapshot of a template, and the ports it runs with.
    /// </summary>
    public sealed partial class TemplateVersion
    {
        /// <summary>
        /// Pass as `version_id` on `POST /v1/flows/templates/{template_id}/runs` to pin a run to this snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// When this version was published, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset PublishedAtUnix { get; set; }

        /// <summary>
        /// Whether this is the version a run gets when `version_id` is omitted or set to `latest`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_latest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLatest { get; set; }

        /// <summary>
        /// The inputs this version accepts, in canvas order. Every input is required on a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort> Inputs { get; set; }

        /// <summary>
        /// The outputs this version produces, in canvas order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort> Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersion" /> class.
        /// </summary>
        /// <param name="versionId">
        /// Pass as `version_id` on `POST /v1/flows/templates/{template_id}/runs` to pin a run to this snapshot.
        /// </param>
        /// <param name="publishedAtUnix">
        /// When this version was published, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="isLatest">
        /// Whether this is the version a run gets when `version_id` is omitted or set to `latest`.
        /// </param>
        /// <param name="inputs">
        /// The inputs this version accepts, in canvas order. Every input is required on a run.
        /// </param>
        /// <param name="outputs">
        /// The outputs this version produces, in canvas order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateVersion(
            string versionId,
            global::System.DateTimeOffset publishedAtUnix,
            bool isLatest,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort> inputs,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort> outputs)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.PublishedAtUnix = publishedAtUnix;
            this.IsLatest = isLatest;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersion" /> class.
        /// </summary>
        public TemplateVersion()
        {
        }

    }
}