
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Input values keyed by input port id. Every input port of the version being run must be given; a missing or unknown id is rejected. Pass `{}` for a template with no inputs.
    /// </summary>
    public sealed partial class TemplateRunCreateRequestInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}