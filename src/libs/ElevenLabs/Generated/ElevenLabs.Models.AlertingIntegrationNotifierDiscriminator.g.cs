
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertingIntegrationNotifierDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AlertingIntegrationNotifierDiscriminatorIntegrationTypeJsonConverter))]
        public global::ElevenLabs.AlertingIntegrationNotifierDiscriminatorIntegrationType? IntegrationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingIntegrationNotifierDiscriminator" /> class.
        /// </summary>
        /// <param name="integrationType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingIntegrationNotifierDiscriminator(
            global::ElevenLabs.AlertingIntegrationNotifierDiscriminatorIntegrationType? integrationType)
        {
            this.IntegrationType = integrationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingIntegrationNotifierDiscriminator" /> class.
        /// </summary>
        public AlertingIntegrationNotifierDiscriminator()
        {
        }

    }
}