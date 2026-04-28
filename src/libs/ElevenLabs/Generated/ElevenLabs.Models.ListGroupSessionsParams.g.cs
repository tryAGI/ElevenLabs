
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// List scheduled group sessions for a group service in a date range.<br/>
    /// Group services are scheduled in advance (e.g. yoga classes, workshops) and<br/>
    /// callers register against an existing session. Use this for group services;<br/>
    /// use ``check_service_availability`` for appointment / rental services.
    /// </summary>
    public sealed partial class ListGroupSessionsParams
    {
        /// <summary>
        /// Default Value: list_group_sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroupSessionsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: list_group_sessions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGroupSessionsParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroupSessionsParams" /> class.
        /// </summary>
        public ListGroupSessionsParams()
        {
        }
    }
}