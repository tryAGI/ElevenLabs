
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object re-validated against the input port's modality — see `TemplateRunCreateRequestModel.inputs`.
    /// </summary>
    public sealed partial class TemplateRunPreflightRequestModelInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}