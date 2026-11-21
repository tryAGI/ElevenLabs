
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FieldConflict
    {
        /// <summary>
        /// Identifier of the conflicting field relative to its section: a dot-path within conversation_config/platform_settings (e.g. `tts.voice_id`), a procedure id, or a workflow path: `nodes.&lt;id&gt;`, `edges.&lt;id&gt;`, or the name of a top-level workflow setting.
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
        /// Stable identifier of this conflict within a merge.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether a resolution of this conflict may use `custom` with a `custom_value` instead of keeping a side.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepts_custom_value")]
        public bool AcceptsCustomValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldConflict" /> class.
        /// </summary>
        /// <param name="path">
        /// Identifier of the conflicting field relative to its section: a dot-path within conversation_config/platform_settings (e.g. `tts.voice_id`), a procedure id, or a workflow path: `nodes.&lt;id&gt;`, `edges.&lt;id&gt;`, or the name of a top-level workflow setting.
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
        /// <param name="id">
        /// Stable identifier of this conflict within a merge.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="acceptsCustomValue">
        /// Whether a resolution of this conflict may use `custom` with a `custom_value` instead of keeping a side.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldConflict(
            string path,
            global::ElevenLabs.ConflictSection section,
            object? baseValue,
            object? sourceValue,
            object? targetValue,
            string id = default!,
            bool acceptsCustomValue = default!)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Section = section;
            this.BaseValue = baseValue;
            this.SourceValue = sourceValue;
            this.TargetValue = targetValue;
            this.Id = id;
            this.AcceptsCustomValue = acceptsCustomValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldConflict" /> class.
        /// </summary>
        public FieldConflict()
        {
        }

    }
}