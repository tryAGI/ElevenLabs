
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SyncSlackRequestersRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConnectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncSlackRequestersRequest" /> class.
        /// </summary>
        /// <param name="integrationConnectionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncSlackRequestersRequest(
            string integrationConnectionId)
        {
            this.IntegrationConnectionId = integrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(integrationConnectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncSlackRequestersRequest" /> class.
        /// </summary>
        public SyncSlackRequestersRequest()
        {
        }

    }
}