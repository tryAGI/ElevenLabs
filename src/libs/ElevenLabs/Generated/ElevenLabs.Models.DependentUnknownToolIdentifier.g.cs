
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A model that represents an tool dependent on a knowledge base/tools<br/>
    /// to which the user has no direct access.
    /// </summary>
    public sealed partial class DependentUnknownToolIdentifier
    {
        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownToolIdentifier" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependentUnknownToolIdentifier(
            string id,
            string? type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownToolIdentifier" /> class.
        /// </summary>
        public DependentUnknownToolIdentifier()
        {
        }

    }
}