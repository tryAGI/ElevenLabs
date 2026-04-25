
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManualSource
    {
        /// <summary>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedByUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualSource" /> class.
        /// </summary>
        /// <param name="createdByUserId"></param>
        /// <param name="type">
        /// Default Value: manual
        /// </param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManualSource(
            string createdByUserId,
            string? type,
            string? notes)
        {
            this.Type = type;
            this.CreatedByUserId = createdByUserId ?? throw new global::System.ArgumentNullException(nameof(createdByUserId));
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualSource" /> class.
        /// </summary>
        public ManualSource()
        {
        }
    }
}