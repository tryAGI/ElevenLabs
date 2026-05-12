
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeToolAllowedDomain
    {
        /// <summary>
        /// Domain pattern that code tools can access. Must be a valid domain (e.g. api.github.com), optionally with a subdomain wildcard (*.example.com) or path glob (api.example.com/v1/*).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Human-readable label for this domain entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToolAllowedDomain" /> class.
        /// </summary>
        /// <param name="domain">
        /// Domain pattern that code tools can access. Must be a valid domain (e.g. api.github.com), optionally with a subdomain wildcard (*.example.com) or path glob (api.example.com/v1/*).
        /// </param>
        /// <param name="name">
        /// Human-readable label for this domain entry
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeToolAllowedDomain(
            string domain,
            string name)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeToolAllowedDomain" /> class.
        /// </summary>
        public CodeToolAllowedDomain()
        {
        }

    }
}