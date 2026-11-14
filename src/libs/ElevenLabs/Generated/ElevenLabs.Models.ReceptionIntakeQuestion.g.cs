
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A question the receptionist asks before booking or ordering this item.
    /// </summary>
    public sealed partial class ReceptionIntakeQuestion
    {
        /// <summary>
        /// Stable identifier referenced by stored answers. Survives label edits so history stays attributable to the right question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The question as the agent should ask it, e.g. 'How many rooms?'. Phrased by the owner; the agent may rephrase for conversational flow but must not change what is being asked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The answer's shape: free text, a number, or one of options.<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.IntakeQuestionKindJsonConverter))]
        public global::ElevenLabs.IntakeQuestionKind? Kind { get; set; }

        /// <summary>
        /// Allowed answers for `kind='choice'`. Must be empty for the other kinds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// Enforced on the booking page. On calls the receptionist asks, but still books if the caller won't answer.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Retired questions are deactivated rather than deleted, so answers already stored against them keep resolving.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionIntakeQuestion" /> class.
        /// </summary>
        /// <param name="label">
        /// The question as the agent should ask it, e.g. 'How many rooms?'. Phrased by the owner; the agent may rephrase for conversational flow but must not change what is being asked.
        /// </param>
        /// <param name="id">
        /// Stable identifier referenced by stored answers. Survives label edits so history stays attributable to the right question.
        /// </param>
        /// <param name="kind">
        /// The answer's shape: free text, a number, or one of options.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="options">
        /// Allowed answers for `kind='choice'`. Must be empty for the other kinds.
        /// </param>
        /// <param name="required">
        /// Enforced on the booking page. On calls the receptionist asks, but still books if the caller won't answer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isActive">
        /// Retired questions are deactivated rather than deleted, so answers already stored against them keep resolving.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionIntakeQuestion(
            string label,
            string? id,
            global::ElevenLabs.IntakeQuestionKind? kind,
            global::System.Collections.Generic.IList<string>? options,
            bool? required,
            bool? isActive)
        {
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Kind = kind;
            this.Options = options;
            this.Required = required;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionIntakeQuestion" /> class.
        /// </summary>
        public ReceptionIntakeQuestion()
        {
        }

    }
}