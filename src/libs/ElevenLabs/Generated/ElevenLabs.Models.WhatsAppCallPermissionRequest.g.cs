
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhatsAppCallPermissionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WhatsAppCallPermissionRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WhatsAppCallPermissionRequestState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at_unix")]
        public int? RequestedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responded_at_unix")]
        public int? RespondedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_by_user_call")]
        public bool? GrantedByUserCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppCallPermissionRequest" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="requestedAtUnix"></param>
        /// <param name="respondedAtUnix"></param>
        /// <param name="permanent"></param>
        /// <param name="grantedByUserCall"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppCallPermissionRequest(
            global::ElevenLabs.WhatsAppCallPermissionRequestState state,
            int? requestedAtUnix,
            int? respondedAtUnix,
            bool? permanent,
            bool? grantedByUserCall)
        {
            this.State = state;
            this.RequestedAtUnix = requestedAtUnix;
            this.RespondedAtUnix = respondedAtUnix;
            this.Permanent = permanent;
            this.GrantedByUserCall = grantedByUserCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppCallPermissionRequest" /> class.
        /// </summary>
        public WhatsAppCallPermissionRequest()
        {
        }

    }
}