
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SMBUpdateCustomerFacingAgentRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::ElevenLabs.CustomerFacingConfigPatch? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.SMBWidgetAppearance? Widget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateCustomerFacingAgentRequest" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="name"></param>
        /// <param name="widget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBUpdateCustomerFacingAgentRequest(
            global::ElevenLabs.CustomerFacingConfigPatch? config,
            string? name,
            global::ElevenLabs.SMBWidgetAppearance? widget)
        {
            this.Config = config;
            this.Name = name;
            this.Widget = widget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBUpdateCustomerFacingAgentRequest" /> class.
        /// </summary>
        public SMBUpdateCustomerFacingAgentRequest()
        {
        }

    }
}