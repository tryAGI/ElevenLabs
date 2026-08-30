
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TriggeredGuardrailCommonModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GuardrailTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.GuardrailType GuardrailType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        public string? GuardrailName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggeredGuardrailCommonModel" /> class.
        /// </summary>
        /// <param name="guardrailType"></param>
        /// <param name="guardrailName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggeredGuardrailCommonModel(
            global::ElevenLabs.GuardrailType guardrailType,
            string? guardrailName)
        {
            this.GuardrailType = guardrailType;
            this.GuardrailName = guardrailName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggeredGuardrailCommonModel" /> class.
        /// </summary>
        public TriggeredGuardrailCommonModel()
        {
        }

    }
}