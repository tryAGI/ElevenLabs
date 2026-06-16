
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OmitSchemaOverride
    {
        /// <summary>
        /// Default Value: omit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitSchemaOverride" /> class.
        /// </summary>
        /// <param name="source">
        /// Default Value: omit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OmitSchemaOverride(
            string? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitSchemaOverride" /> class.
        /// </summary>
        public OmitSchemaOverride()
        {
        }

    }
}