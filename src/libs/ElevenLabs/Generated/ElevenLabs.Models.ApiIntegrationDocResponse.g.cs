
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"doc_mdx":"## Overview\n\nConnect your ElevenLabs AI agents with HubSpot CRM.\n\n{/* app:end */}\n\n## Demo video\n...","id":"hubspot","name":"HubSpot"}
    /// </summary>
    public sealed partial class ApiIntegrationDocResponse
    {
        /// <summary>
        /// Integration identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Full MDX documentation content for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_mdx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocMdx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationDocResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Integration identifier
        /// </param>
        /// <param name="name">
        /// Display name of the integration
        /// </param>
        /// <param name="docMdx">
        /// Full MDX documentation content for the integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiIntegrationDocResponse(
            string id,
            string name,
            string docMdx)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DocMdx = docMdx ?? throw new global::System.ArgumentNullException(nameof(docMdx));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationDocResponse" /> class.
        /// </summary>
        public ApiIntegrationDocResponse()
        {
        }

    }
}