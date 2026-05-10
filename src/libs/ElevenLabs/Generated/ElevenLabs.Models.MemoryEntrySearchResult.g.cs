
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryEntrySearchResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryEntrySearchResult" /> class.
        /// </summary>
        /// <param name="entryId"></param>
        /// <param name="version"></param>
        /// <param name="summary"></param>
        /// <param name="text"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoryEntrySearchResult(
            string entryId,
            int version,
            string? summary,
            string? text,
            global::ElevenLabs.AnyOf<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>? source)
        {
            this.EntryId = entryId ?? throw new global::System.ArgumentNullException(nameof(entryId));
            this.Version = version;
            this.Summary = summary;
            this.Text = text;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryEntrySearchResult" /> class.
        /// </summary>
        public MemoryEntrySearchResult()
        {
        }

    }
}