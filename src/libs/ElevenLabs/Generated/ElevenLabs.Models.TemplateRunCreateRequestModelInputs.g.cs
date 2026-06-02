
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object; the server re-validates the binding against the input port's modality at run time, so populate the fields that match the value you have (`content_asset_id`, `generation_id`, `template_node_id`, `studio_clip`, or `inline_text` for text).
    /// </summary>
    public sealed partial class TemplateRunCreateRequestModelInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}