
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"namespace":"external","value":"jane@example.com"}
    /// </summary>
    public sealed partial class FindAgentsUserByIdentityRequestModel
    {
        /// <summary>
        /// Namespace of the identity, e.g. `external` for the `user_id` a conversation initiation webhook or API request gave, or `email`.<br/>
        /// Default Value: external
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Value of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindAgentsUserByIdentityRequestModel" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of the identity.
        /// </param>
        /// <param name="namespace">
        /// Namespace of the identity, e.g. `external` for the `user_id` a conversation initiation webhook or API request gave, or `email`.<br/>
        /// Default Value: external
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindAgentsUserByIdentityRequestModel(
            string value,
            string? @namespace)
        {
            this.Namespace = @namespace;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindAgentsUserByIdentityRequestModel" /> class.
        /// </summary>
        public FindAgentsUserByIdentityRequestModel()
        {
        }

    }
}