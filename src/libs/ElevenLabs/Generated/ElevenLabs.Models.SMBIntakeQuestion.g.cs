
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One owner-authored question the agent asks before booking/ordering this item.<br/>
    /// This is the structured counterpart to the agent-wide<br/>
    /// ``CustomerFacingConfig.details_to_collect``: scoped to a single catalog<br/>
    /// item, and typed so the answer is usable afterwards (rendered in the inbox,<br/>
    /// filterable, and eventually an input to pricing) rather than just readable.
    /// </summary>
    public sealed partial class SMBIntakeQuestion
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
        /// Answer shape for a per-item intake question.<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.IntakeQuestionKindJsonConverter))]
        public global::ElevenLabs.IntakeQuestionKind? Kind { get; set; }

        /// <summary>
        /// Allowed answers for ``kind='choice'``. Must be empty for the other kinds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// On the public booking page this is enforced as a form constraint. On a voice call it is only an instruction to the agent: hard-rejecting a booking mid-conversation because the caller dodged a question is worse for the caller than a booking with a gap the owner can chase. Do not 'fix' this into a server-side constraint for the voice path.<br/>
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
        /// Initializes a new instance of the <see cref="SMBIntakeQuestion" /> class.
        /// </summary>
        /// <param name="label">
        /// The question as the agent should ask it, e.g. 'How many rooms?'. Phrased by the owner; the agent may rephrase for conversational flow but must not change what is being asked.
        /// </param>
        /// <param name="id">
        /// Stable identifier referenced by stored answers. Survives label edits so history stays attributable to the right question.
        /// </param>
        /// <param name="kind">
        /// Answer shape for a per-item intake question.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="options">
        /// Allowed answers for ``kind='choice'``. Must be empty for the other kinds.
        /// </param>
        /// <param name="required">
        /// On the public booking page this is enforced as a form constraint. On a voice call it is only an instruction to the agent: hard-rejecting a booking mid-conversation because the caller dodged a question is worse for the caller than a booking with a gap the owner can chase. Do not 'fix' this into a server-side constraint for the voice path.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isActive">
        /// Retired questions are deactivated rather than deleted, so answers already stored against them keep resolving.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBIntakeQuestion(
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
        /// Initializes a new instance of the <see cref="SMBIntakeQuestion" /> class.
        /// </summary>
        public SMBIntakeQuestion()
        {
        }

    }
}