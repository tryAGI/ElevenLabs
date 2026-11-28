
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SipUriDynamicVariableDestinationOutput
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
        /// <default>"sip_uri_dynamic_variable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "sip_uri_dynamic_variable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipUriDynamicVariableDestinationOutput" /> class.
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
        public SipUriDynamicVariableDestinationOutput(
            string destination,
            string type = "sip_uri_dynamic_variable")
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipUriDynamicVariableDestinationOutput" /> class.
        /// </summary>
        public SipUriDynamicVariableDestinationOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SipUriDynamicVariableDestinationOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SipUriDynamicVariableDestinationOutput FromDestination(string destination)
        {
            return new SipUriDynamicVariableDestinationOutput
            {
                Destination = destination,
            };
        }

    }
}