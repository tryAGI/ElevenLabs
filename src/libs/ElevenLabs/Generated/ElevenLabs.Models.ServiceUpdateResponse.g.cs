
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServiceUpdateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public global::ElevenLabs.SMBServiceDBModel? Service { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_affected_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAffectedEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUpdateResponse" /> class.
        /// </summary>
        /// <param name="hasAffectedEvents"></param>
        /// <param name="service"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceUpdateResponse(
            bool hasAffectedEvents,
            global::ElevenLabs.SMBServiceDBModel? service)
        {
            this.Service = service;
            this.HasAffectedEvents = hasAffectedEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUpdateResponse" /> class.
        /// </summary>
        public ServiceUpdateResponse()
        {
        }

    }
}