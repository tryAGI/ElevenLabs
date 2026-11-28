
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RenderedUserMemoryEntity
    {
        /// <summary>
        /// ID of the entity, to delete it with everything known about it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// e.g. `Piotr N`. The user themselves is `user`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// e.g. `person`, `company`, `dog`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Whether this is the user themselves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsUser { get; set; }

        /// <summary>
        /// How the user relates to it, e.g. `colleague`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact> Relations { get; set; }

        /// <summary>
        /// What holds about it until something replaces it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact> Facts { get; set; }

        /// <summary>
        /// Things that happened once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedUserMemoryEntity" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the entity, to delete it with everything known about it.
        /// </param>
        /// <param name="name">
        /// e.g. `Piotr N`. The user themselves is `user`.
        /// </param>
        /// <param name="type">
        /// e.g. `person`, `company`, `dog`.
        /// </param>
        /// <param name="isUser">
        /// Whether this is the user themselves.
        /// </param>
        /// <param name="relations">
        /// How the user relates to it, e.g. `colleague`.
        /// </param>
        /// <param name="facts">
        /// What holds about it until something replaces it.
        /// </param>
        /// <param name="events">
        /// Things that happened once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderedUserMemoryEntity(
            string id,
            string name,
            string type,
            bool isUser,
            global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact> relations,
            global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact> facts,
            global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact> events)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.IsUser = isUser;
            this.Relations = relations ?? throw new global::System.ArgumentNullException(nameof(relations));
            this.Facts = facts ?? throw new global::System.ArgumentNullException(nameof(facts));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedUserMemoryEntity" /> class.
        /// </summary>
        public RenderedUserMemoryEntity()
        {
        }

    }
}