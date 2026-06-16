
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How many minutes an alert can stay inactive before it is auto-resolved. Unset values fall through to the next layer.
    /// </summary>
    public sealed partial class AlertingSettingsAutoResolveAfterInactiveMinutes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}