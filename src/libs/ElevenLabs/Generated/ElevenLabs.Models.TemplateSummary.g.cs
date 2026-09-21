
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A template the caller can run, and its runnable versions.
    /// </summary>
    public sealed partial class TemplateSummary
    {
        /// <summary>
        /// Pass as `template_id` on `POST /v1/flows/templates/{template_id}/runs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The template's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The template's description, if it has one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The published versions this caller can run, newest first. A version whose graph uses a model that is not available to you through the API is left out, as is one whose stored snapshot is gone; either way the list can be empty while the template still has versions the ElevenLabs app can run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion> Versions { get; set; }

        /// <summary>
        /// Whether this template has further published versions beyond the `versions_per_template` returned here. Fetch `GET /v1/flows/templates/{template_id}` with a larger `versions_per_template` to see more of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMoreVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// Pass as `template_id` on `POST /v1/flows/templates/{template_id}/runs`.
        /// </param>
        /// <param name="name">
        /// The template's name.
        /// </param>
        /// <param name="versions">
        /// The published versions this caller can run, newest first. A version whose graph uses a model that is not available to you through the API is left out, as is one whose stored snapshot is gone; either way the list can be empty while the template still has versions the ElevenLabs app can run.
        /// </param>
        /// <param name="hasMoreVersions">
        /// Whether this template has further published versions beyond the `versions_per_template` returned here. Fetch `GET /v1/flows/templates/{template_id}` with a larger `versions_per_template` to see more of them.
        /// </param>
        /// <param name="description">
        /// The template's description, if it has one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateSummary(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion> versions,
            bool hasMoreVersions,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.HasMoreVersions = hasMoreVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummary" /> class.
        /// </summary>
        public TemplateSummary()
        {
        }

    }
}