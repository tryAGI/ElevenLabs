
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionUpdateCustomerFacingAgentRequest
    {
        /// <summary>
        /// Receptionist settings to change; omitted settings keep their value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::ElevenLabs.ReceptionCustomerFacingConfigPatch? Config { get; set; }

        /// <summary>
        /// New display name for the receptionist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New website widget appearance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.ReceptionWidgetAppearance? Widget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateCustomerFacingAgentRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Receptionist settings to change; omitted settings keep their value.
        /// </param>
        /// <param name="name">
        /// New display name for the receptionist.
        /// </param>
        /// <param name="widget">
        /// New website widget appearance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionUpdateCustomerFacingAgentRequest(
            global::ElevenLabs.ReceptionCustomerFacingConfigPatch? config,
            string? name,
            global::ElevenLabs.ReceptionWidgetAppearance? widget)
        {
            this.Config = config;
            this.Name = name;
            this.Widget = widget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateCustomerFacingAgentRequest" /> class.
        /// </summary>
        public ReceptionUpdateCustomerFacingAgentRequest()
        {
        }

    }
}