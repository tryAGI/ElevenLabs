
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldConflict
    {
        /// <summary>
        /// Identifier of the conflicting field relative to its section: a dot-path within conversation_config/platform_settings, or a procedure id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Which config section this path belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConflictSectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConflictSection Section { get; set; }

        /// <summary>
        /// Value at the common ancestor (merge base).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_value")]
        public object? BaseValue { get; set; }

        /// <summary>
        /// Value on the source branch tip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_value")]
        public object? SourceValue { get; set; }

        /// <summary>
        /// Value on the target branch tip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_value")]
        public object? TargetValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldConflict" /> class.
        /// </summary>
        /// <param name="path">
        /// Identifier of the conflicting field relative to its section: a dot-path within conversation_config/platform_settings, or a procedure id.
        /// </param>
        /// <param name="section">
        /// Which config section this path belongs to.
        /// </param>
        /// <param name="baseValue">
        /// Value at the common ancestor (merge base).
        /// </param>
        /// <param name="sourceValue">
        /// Value on the source branch tip.
        /// </param>
        /// <param name="targetValue">
        /// Value on the target branch tip.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldConflict(
            string path,
            global::ElevenLabs.ConflictSection section,
            object? baseValue,
            object? sourceValue,
            object? targetValue)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Section = section;
            this.BaseValue = baseValue;
            this.SourceValue = sourceValue;
            this.TargetValue = targetValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldConflict" /> class.
        /// </summary>
        public FieldConflict()
        {
        }

    }
}