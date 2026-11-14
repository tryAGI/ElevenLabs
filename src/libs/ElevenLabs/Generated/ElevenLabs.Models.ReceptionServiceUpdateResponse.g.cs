
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionServiceUpdateResponse
    {
        /// <summary>
        /// The updated service, or null when the update was held back because it reprices existing bookings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public global::ElevenLabs.ReceptionService? Service { get; set; }

        /// <summary>
        /// True when the update changes the price of upcoming bookings and was not saved; send it again to the confirm-update endpoint to apply it.
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
        /// Initializes a new instance of the <see cref="ReceptionServiceUpdateResponse" /> class.
        /// </summary>
        /// <param name="hasAffectedEvents">
        /// True when the update changes the price of upcoming bookings and was not saved; send it again to the confirm-update endpoint to apply it.
        /// </param>
        /// <param name="service">
        /// The updated service, or null when the update was held back because it reprices existing bookings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionServiceUpdateResponse(
            bool hasAffectedEvents,
            global::ElevenLabs.ReceptionService? service)
        {
            this.Service = service;
            this.HasAffectedEvents = hasAffectedEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionServiceUpdateResponse" /> class.
        /// </summary>
        public ReceptionServiceUpdateResponse()
        {
        }

    }
}