
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertingIntegrationNotifierResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AlertingIntegrationNotifierResponseDiscriminatorIntegrationTypeJsonConverter))]
        public global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? IntegrationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingIntegrationNotifierResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="integrationType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingIntegrationNotifierResponseDiscriminator(
            global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? integrationType)
        {
            this.IntegrationType = integrationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingIntegrationNotifierResponseDiscriminator" /> class.
        /// </summary>
        public AlertingIntegrationNotifierResponseDiscriminator()
        {
        }

    }
}