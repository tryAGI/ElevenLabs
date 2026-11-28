
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Open time ranges per day of the week, keyed 0 (Monday) to 6 (Sunday). A day with no ranges is closed.
    /// </summary>
    public sealed partial class WorkingHoursHours
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}