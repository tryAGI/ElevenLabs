
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneDynamicVariableDestinationOutput
    {
        /// <summary>
        /// Phone number, SIP URI, or the dynamic variable name that resolves to one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// Default Value: phone_dynamic_variable
        /// </summary>
        /// <default>"phone_dynamic_variable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "phone_dynamic_variable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneDynamicVariableDestinationOutput" /> class.
        /// </summary>
        /// <param name="destination">
        /// Phone number, SIP URI, or the dynamic variable name that resolves to one.
        /// </param>
        /// <param name="type">
        /// Default Value: phone_dynamic_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneDynamicVariableDestinationOutput(
            string destination,
            string type = "phone_dynamic_variable")
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneDynamicVariableDestinationOutput" /> class.
        /// </summary>
        public PhoneDynamicVariableDestinationOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PhoneDynamicVariableDestinationOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PhoneDynamicVariableDestinationOutput FromDestination(string destination)
        {
            return new PhoneDynamicVariableDestinationOutput
            {
                Destination = destination,
            };
        }

    }
}