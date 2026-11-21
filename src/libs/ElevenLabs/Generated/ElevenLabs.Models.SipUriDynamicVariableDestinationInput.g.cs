
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SipUriDynamicVariableDestinationInput
    {
        /// <summary>
        /// Phone number, SIP URI, or the dynamic variable name that resolves to one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// Default Value: sip_uri_dynamic_variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipUriDynamicVariableDestinationInput" /> class.
        /// </summary>
        /// <param name="destination">
        /// Phone number, SIP URI, or the dynamic variable name that resolves to one.
        /// </param>
        /// <param name="type">
        /// Default Value: sip_uri_dynamic_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SipUriDynamicVariableDestinationInput(
            string destination,
            string? type)
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipUriDynamicVariableDestinationInput" /> class.
        /// </summary>
        public SipUriDynamicVariableDestinationInput()
        {
        }

    }
}