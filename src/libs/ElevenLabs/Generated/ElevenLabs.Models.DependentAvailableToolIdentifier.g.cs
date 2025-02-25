
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependentAvailableToolIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierTypeJsonConverter))]
        public global::ElevenLabs.DependentAvailableToolIdentifierType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableToolIdentifier" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: available
        /// </param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="accessLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependentAvailableToolIdentifier(
            string id,
            string name,
            int createdAtUnixSecs,
            global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel accessLevel,
            global::ElevenLabs.DependentAvailableToolIdentifierType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.AccessLevel = accessLevel;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableToolIdentifier" /> class.
        /// </summary>
        public DependentAvailableToolIdentifier()
        {
        }
    }
}