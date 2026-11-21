
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnyOfJsonSchemaPropertyOutput
    {
        /// <summary>
        /// The object shapes the value can take.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ObjectJsonSchemaPropertyOutput> AnyOf { get; set; }

        /// <summary>
        /// The property every branch declares as a required string with a single enum value; that value names the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discriminator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Discriminator { get; set; }

        /// <summary>
        /// What the value is, for the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnyOfJsonSchemaPropertyOutput" /> class.
        /// </summary>
        /// <param name="anyOf">
        /// The object shapes the value can take.
        /// </param>
        /// <param name="discriminator">
        /// The property every branch declares as a required string with a single enum value; that value names the branch.
        /// </param>
        /// <param name="description">
        /// What the value is, for the LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnyOfJsonSchemaPropertyOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.ObjectJsonSchemaPropertyOutput> anyOf,
            string discriminator,
            string? description)
        {
            this.AnyOf = anyOf ?? throw new global::System.ArgumentNullException(nameof(anyOf));
            this.Discriminator = discriminator ?? throw new global::System.ArgumentNullException(nameof(discriminator));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnyOfJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public AnyOfJsonSchemaPropertyOutput()
        {
        }

    }
}